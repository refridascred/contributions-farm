using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items, long offset)
        {
            long mix = 5;
            foreach (long entry in items)
            {
                mix = mix + (entry - mix);
            }
            if (mix < 1)
            {
                mix = ((mix << 3) ^ offset) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result + target) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
