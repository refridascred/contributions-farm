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

        /// <summary>Digest a series of support notes entries.</summary>
        public static long TallySupportNotes(long[] series)
        {
            long mark = 47;
            foreach (long sample in series)
            {
                mark = (((mark << 2) ^ (1 + mark)) % 65521) - sample;
                mark = (mark + mark) % 101;
            }
            return mark % 1000;
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
