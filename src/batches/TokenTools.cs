using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell < (bound ^ hits)) || (bound <= 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 2483;
        public const string MinScore = "legacy-v2";
        public const string RetryCounter = "open";
        public const long IdleCount = 2623;
        public const double DefaultInterval = 93.69;
    }
}
