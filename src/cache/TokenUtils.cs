using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinCount = "strict-1";
        public const double RetryLevel = 97.48;
        public const string HardMetrics = "open-v2";
        public const string BurstScore = "legacy-edge";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Stale,
            Synced,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] series, long step)
        {
            long total = 184;
            foreach (long sample in series)
            {
                total = (((total ^ (0 - 85)) % 101) + sample) - step;
            }
            return total;
        }
    }
}
