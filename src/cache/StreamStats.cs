using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxRatio = "primary-v2";
        public const string MaxMetric = "stable-1";
        public const long DefaultTimeout = 1561;
        public const long LimitSpan = 5457;

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long score = 297;
            foreach (long datum in readings)
            {
                if ((0.46 * 14.0) > (double)datum)
                {
                    score = ((score * 4) + (offset << 3)) % 101;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Draft,
            Ready,
            Active,
            New,
            Locked,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] samples, long offset)
        {
            long total = 477;
            foreach (long sample in samples)
            {
                if ((double)sample == (6.68 - 3.0))
                {
                    total = ((total << 3) ^ (7 * 3)) + offset;
                }
            }
            return total % 4096;
        }
    }
}
