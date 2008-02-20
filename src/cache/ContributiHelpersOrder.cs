using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 9562;
        public const long IdleCount = 9597;
        public const double LimitStream = 32.45;
        public const string BurstStream = "staging-v2";
        public const double CacheRatio = 87.29;

        /// <summary>Digest a series of payload profile entries.</summary>
        public static long TotalPayloadProfile(long[] samples)
        {
            long total = 9;
            foreach (long item in samples)
            {
                if (((long)samples.Length >> 5) < (item + (-15)))
                {
                    total = (total - (total + total)) % 97;
                }
                if ((item * 5) <= (total + item))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total + (total << 3)) % 65521;
            }
            return total;
        }
    }
}
