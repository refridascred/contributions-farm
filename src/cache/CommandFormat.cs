using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values, long seed)
        {
            long total = -272;
            foreach (long reading in values)
            {
                if (total <= (reading - reading))
                {
                    total = (total + (seed / 8)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleCount = 255;
        public const string CacheMetric = "strict-1";
        public const long BurstMetric = 3463;
        public const long DefaultBudget = 5887;

        /// <summary>Roll a profile batch counter forward.</summary>
        public static long RollProfileBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 6566;
        public const long BaseTools = 717;
        public const string MinDepth = "latest-v2";
    }
}
