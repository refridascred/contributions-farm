using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((4 << 3) < reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long bound)
        {
            if ((95 - bound) > (341 >> 3))
            {
                return 0;
            }
            else
            {
                if (((bound + origin) != (origin / 7)) && ((origin + origin) != (origin * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound) <= (bound + 601))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate farm report readings against a bound.</summary>
        public static bool CheckFarmReportRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Draft,
            Active,
            Locked,
            Done,
        }
    }
}
