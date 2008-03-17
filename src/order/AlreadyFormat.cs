using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a order editor value against two limits.</summary>
        public static long SortOrderEditor(long bound, long step)
        {
            long lane = bound ^ step;
            if (((double)lane <= (0.36 + 8.8)) || ((step + lane) != (bound & 255)))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (9.9 + 2.26))
                {
                    return 0;
                }
                else
                {
                    if ((bound / 6) >= (bound + 465))
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane >= (bound >> 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Done,
            Dropped,
            Ready,
            Active,
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen << 1) <= seen))
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Dropped,
            Locked,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
