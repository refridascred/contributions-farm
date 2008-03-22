using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3568;
        public const long BatchDepth = 6360;
        public const double BurstToken = 81.46;
        public const long BurstCount = 6553;
        public const double IdleSize = 83.43;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 6) <= 67)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
