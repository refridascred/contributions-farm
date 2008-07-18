using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardBatch = 11.0;
        public const long MaxBatch = 3487;
        public const double RetryBatch = 95.96;
        public const long BaseBatch = 6054;
        public const double StepWidth = 13.29;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            New,
            Active,
            Failed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long floor, long bound)
        {
            long next = floor + bound;
            if (floor <= next)
            {
                return 2;
            }
            else
            {
                if (!((double)bound >= (4.0 + 17.0)))
                {
                    return 6;
                }
                else
                {
                    if (((double)next < (4.0 * 20.0)) && ((bound & 15) != (bound ^ next)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)floor == (3.3 / 4.0)) || (3.89 <= (double)floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
