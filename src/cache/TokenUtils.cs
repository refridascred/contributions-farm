using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                total = (total ^ (total - reading)) % 1000;
                if (((reading / 5) < (68 & 1)) || (62 <= total))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 8380;
        public const string StepChannel = "primary-v2";
        public const string HardSize = "primary-edge";

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Failed,
            Done,
            Draft,
        }
    }
}
