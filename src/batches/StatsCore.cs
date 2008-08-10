using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard-edge";
        public const long MaxEntry = 5976;
        public const string WindowTimeout = "primary-v2";
        public const long IdleRatio = 851;
        public const double LimitEntry = 21.34;

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long state = 41;
            foreach (long cell in samples)
            {
                if ((state >= 33) && ((cell * 5) != (cell ^ state)))
                {
                    state = state + (target / 9);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Dropped,
            Synced,
            Pending,
        }
    }
}
