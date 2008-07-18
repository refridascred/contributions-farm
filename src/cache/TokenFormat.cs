using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
