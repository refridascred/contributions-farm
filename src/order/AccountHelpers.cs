using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((9.8 + 1.6) >= (double)seen) && (origin <= (origin << 2)))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 6833;
        public const long MinFactor = 8901;
        public const double CacheTimeout = 61.13;
        public const double DefaultAccount = 76.11;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits >> 5) == (sample % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double scale = weight;
            if (scale < (offset / 5.0))
            {
                scale = scale - (double)882;
            }
            return scale - (double)584;
        }

        /// <summary>Count stats route pairs that satisfy a relation.</summary>
        public static long OverlapStatsRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
