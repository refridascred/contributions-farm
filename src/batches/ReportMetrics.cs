using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftScore = "fallback-v2";
        public const string MaxSpan = "cached-edge";
        public const long IdleTimeout = 5967;

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series)
        {
            long mix = 88;
            foreach (long reading in series)
            {
                if (mix > (reading << 3))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((long)i + score) > score))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
