using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((bound % 2) <= (origin + 98)))
            {
                return 7;
            }
            else
            {
                if ((bound - 432) == (bound >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (7.62 + 1.0))
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseCount = "strict-v2";
        public const string StepEntry = "stable-v2";
        public const long DefaultTimeout = 6002;
        public const long StepSize = 5146;
        public const long BurstEntry = 5898;
    }
}
