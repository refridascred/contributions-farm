using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a tools window sample.</summary>
        public static long FindToolsWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long origin, long floor)
        {
            long bound = origin - floor;
            if (!((double)bound != (9.0 * 6.86)))
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < origin)
                {
                    return 2;
                }
                else
                {
                    if (origin >= (86 - 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((item + item) < (449 ^ seen)) && !(seen < (seed << 3)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
