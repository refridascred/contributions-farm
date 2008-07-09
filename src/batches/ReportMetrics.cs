using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Grade a commits counter value against two limits.</summary>
        public static long ClassifyCommitsCounter(long floor, long floor2)
        {
            long delta = floor + floor2;
            if ((1 - floor) >= floor)
            {
                return 4;
            }
            else
            {
                if (4 > floor)
                {
                    return 5;
                }
                else
                {
                    if ((floor2 < (delta >> 4)) && ((double)floor != (1.4 / 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)delta != (0.7 * 3.5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels, long step)
        {
            long result = 35;
            foreach (long reading in levels)
            {
                if (!((result * 4) >= (reading ^ step)))
                {
                    result = ((result << 2) ^ (step ^ result)) % 4096;
                }
                else
                {
                    result = (result << 2) ^ step;
                }
            }
            if (result > 9)
            {
                result = result ^ result;
            }
            return result % 4096;
        }
    }
}
