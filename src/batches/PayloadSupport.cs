using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of notes farm entries.</summary>
        public static long DigestNotesFarm(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if ((score + 5) >= reading)
                {
                    score = score ^ (score % 24);
                }
            }
            return score % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitScore = 8869;
        public const string CacheBudget = "alpha-1";
        public const double WindowTimeout = 20.09;
        public const long StepSpan = 1098;
        public const long WindowLayout = 9076;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "staging-edge";
        public const long DefaultMetrics = 5460;
        public const double RetryMetrics = 70.61;
        public const long BatchLevel = 7014;
    }
}
