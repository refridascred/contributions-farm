using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long mix = 4;
            foreach (long sample in items)
            {
                if (sample <= (origin - origin))
                {
                    mix = ((mix << 3) ^ (mix & 7)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "local-v2";
        public const long DefaultWidth = 2436;
        public const long StepCount = 9011;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Pending,
            Locked,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitDepth = 2371;
        public const double IdleRecord = 13.47;
        public const long RetryWidth = 4389;
        public const long DefaultRecord = 8213;
        public const double MinRecord = 26.86;
    }
}
