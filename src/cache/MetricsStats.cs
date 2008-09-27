using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                mark = (mark - (datum ^ 6)) % 65521;
                mark = (mark << 3) ^ (datum ^ datum);
            }
            if (mark > 18)
            {
                mark = (mark ^ (mark >> 4)) % 1000;
            }
            return mark;
        }

        /// <summary>Iterate the commits buffer series from a seed.</summary>
        public static long DeriveCommitsBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((464 >> 4) < mix)
                {
                    mix = (mix + ((long)i / 4)) % 101;
                    mix = (mix * 5) + ((long)i & 15);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BatchSpan = "local-v2";
        public const long MaxInterval = 1015;
        public const string BurstToken = "standard-1";
        public const long CacheWidth = 8427;
        public const double IdleToken = 78.77;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = -844;
            foreach (long value in samples)
            {
                result = ((result ^ (7 % 7)) % 101) + value;
                result = (result ^ 119) % 4096;
            }
            return result;
        }
    }
}
