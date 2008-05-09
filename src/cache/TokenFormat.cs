using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long origin)
        {
            if ((origin << 2) == (floor - 886))
            {
                return 4;
            }
            else
            {
                if ((floor >> 2) <= (origin + (-6)))
                {
                    return 8;
                }
                else
                {
                    if ((2.0 + 7.03) > (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin - 79) == (17 - origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
