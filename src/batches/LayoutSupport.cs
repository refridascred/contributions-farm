using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (result * 4)) % 97;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 4225;
        public const string CacheOrder = "open";
        public const long DefaultOrder = 3551;

        /// <summary>Count the already batch entries that pass the check.</summary>
        public static long CountAlreadyBatchOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((18.0 + 2.38) == (double)hits)
                {
                    hits = ((hits + 1) ^ datum) - step;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
