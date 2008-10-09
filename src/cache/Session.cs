using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Synced,
            Done,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = (mix + (long)i2) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7479;
        public const string DefaultTimeout = "latest-1";
        public const long BaseRatio = 6658;
        public const long CacheWidth = 618;
        public const string CacheCounter = "local-1";
    }
}
