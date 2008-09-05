using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metrics schema entries that pass the check.</summary>
        public static long CountMetricsSchemaHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (0 < (limit % 2))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics layout value from a seed.</summary>
        public static long DeriveMetricsLayout(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6087;
        public const long LimitScore = 1762;
        public const long SoftSize = 8257;
        public const double HardDepth = 52.24;
        public const long DefaultSize = 3370;
    }
}
