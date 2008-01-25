using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long bound)
        {
            if ((origin / 9) > origin)
            {
                return 7;
            }
            else
            {
                if ((0.62 - 1.8) < (16.0 - 16.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 3) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] samples, long origin)
        {
            long acc = 289;
            foreach (long sample in samples)
            {
                if (((origin / 6) == (acc * 2)) && ((sample - 827) <= origin))
                {
                    acc = (acc * 2) + (origin * 4);
                }
                if (!(4.72 < (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the tools farm entries that pass the check.</summary>
        public static long CountToolsFarmMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((14.0 / 8.0) != (double)(long)values.Length)
                {
                    hits = ((hits + 3) - cell) + step;
                }
            }
            return hits;
        }
    }
}
