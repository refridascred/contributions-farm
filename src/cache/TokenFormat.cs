using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((36 ^ datum) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long bound)
        {
            long span = offset + bound;
            if (!(offset > (bound - span)))
            {
                return 4;
            }
            else
            {
                if (!((bound >> 1) == (bound + 6)))
                {
                    return 1;
                }
                else
                {
                    if ((span % 10) >= bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((14.0 / 9.0) == (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
