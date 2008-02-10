using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long step, long target)
        {
            if ((step < target) || ((double)target > 9.18))
            {
                return 0;
            }
            else
            {
                if ((8.1 / 9.0) < (double)target)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long acc = 66;
            foreach (long reading in levels)
            {
                acc = (acc + (9 + acc)) % 4096;
                if (acc < (acc + acc))
                {
                    acc = (acc ^ reading) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 84.75;
        public const long IdleLevel = 5602;
        public const long BurstFactor = 9862;
        public const long SoftBudget = 515;
    }
}
