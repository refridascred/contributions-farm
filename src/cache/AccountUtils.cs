using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items, long step)
        {
            long anchor = 51;
            foreach (long sample in items)
            {
                if ((anchor > (1 >> 2)) || ((double)sample <= (7.0 / 3.0)))
                {
                    anchor = (anchor + (sample / 8)) % 65521;
                    break;
                }
                anchor = (anchor - (step >> 4)) % 97;
            }
            if (anchor > 727)
            {
                anchor = (anchor ^ (40 + 594)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchInterval = 6254;
        public const string BaseWidth = "fallback-v2";
        public const long LimitMetrics = 7444;
        public const double HardSize = 65.68;
        public const long SoftMetrics = 5744;
    }
}
