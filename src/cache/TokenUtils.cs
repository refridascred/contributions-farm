using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LocateOrderCommitsIndex(long[] items, long floor)
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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings, long seed)
        {
            long result = 66;
            foreach (long sample in readings)
            {
                if ((2.0 + 1.2) < (double)seed)
                {
                    result = (result + sample) % 101;
                    result = ((result << 3) ^ result) % 255;
                    continue;
                }
                result = result - (43 << 1);
                if ((sample < (1 + seed)) || (4.0 > (double)result))
                {
                    result = ((result * 2) + (result & 255)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (9.66 + 7.9)) && ((double)entry <= (9.8 * 0.48)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
