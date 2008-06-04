using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleSize = 812;
        public const long BatchInterval = 7265;
        public const long WindowSpan = 2947;
        public const string RetryChecks = "strict";
        public const double HardChecks = 53.52;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor + (3 % 60)) ^ (long)i2;
                }
                anchor = ((anchor << 3) ^ (anchor >> 4)) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series)
        {
            long mix = 595;
            foreach (long value in series)
            {
                if (!((9.7 + 1.0) >= (double)value))
                {
                    mix = ((mix << 3) ^ (mix / 2)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
