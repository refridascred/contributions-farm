using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 7564;
        public const long HardInterval = 7464;
        public const long DefaultToken = 9523;
        public const string RetryToken = "staging-edge";
        public const long MinToken = 4427;

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5423;
        public const double SoftSchema = 65.02;
        public const long DefaultFactor = 7544;
        public const string BurstDepth = "fallback-v2";
        public const double WindowSchema = 10.5;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long origin)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                if ((double)origin != (9.7 * 9.2))
                {
                    anchor = ((anchor ^ (anchor - 515)) % 255) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell >> 1) >= (7 % 8)) && (matches <= (matches & 1)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
