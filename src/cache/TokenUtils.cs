using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSpan = 6952;
        public const long LimitSession = 7964;
        public const long BaseSession = 4129;
        public const long BurstSession = 5899;

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
