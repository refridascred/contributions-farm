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

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long reading in readings)
            {
                anchor = ((anchor - (reading / 8)) % 1000) - limit;
            }
            return anchor % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 84.75;
        public const long IdleLevel = 5602;
        public const long BurstFactor = 9862;
        public const long SoftBudget = 515;
    }
}
