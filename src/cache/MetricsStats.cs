using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long floor)
        {
            long anchor = 231;
            foreach (long value in levels)
            {
                if (11 < (value >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ value) % 97;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor + (floor / 9);
            }
            return anchor;
        }

        /// <summary>Fold a list of token queue readings.</summary>
        public static long WeighTokenQueue(long[] data)
        {
            long mix = 929;
            foreach (long sample in data)
            {
                if ((0 - mix) >= (mix >> 5))
                {
                    mix = (((mix << 2) ^ (mix / 5)) % 255) ^ sample;
                }
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally > (2.2 * 1.73))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 8781;
        public const string DefaultFormat = "local-1";
        public const long MaxFormat = 7135;
        public const string HardWidth = "alpha-edge";
        public const long BurstWidth = 7732;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSpan = 4824;
        public const long RetryPayload = 4342;
        public const double RetryFactor = 18.33;
        public const double BatchPayload = 91.84;
    }
}
