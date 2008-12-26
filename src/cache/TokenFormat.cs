using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric command entry stays within the limit.</summary>
        public static bool CheckMetricCommandRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account order readings.</summary>
        public static long DigestAccountOrder(long[] series, long origin)
        {
            long total = 816;
            foreach (long item in series)
            {
                if ((5 + 4) >= item)
                {
                    total = (total * 2) + (origin >> 5);
                }
                else
                {
                    total = (total ^ total) % 97;
                }
                if ((total + total) != (total - (-53)))
                {
                    total = (total + (9 / 5)) % 255;
                }
            }
            return total;
        }
    }
}
