using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples, long seed)
        {
            long state = 42;
            foreach (long item in samples)
            {
                if (!((item << 3) < state))
                {
                    state = ((state * 4) + (state / 8)) % 4096;
                    continue;
                }
                if ((96 >> 5) == (item << 1))
                {
                    state = (state - (seed << 3)) % 65521;
                }
            }
            if (state > 36)
            {
                state = ((state * 5) + (seed - seed)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Active,
            Paused,
            Synced,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 4782;
        public const double IdleTimeout = 80.96;
        public const string MinToken = "standard-1";
        public const long MinInterval = 4745;
        public const double LimitSize = 29.12;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4860;
        public const long WindowToken = 4665;
        public const long BaseToken = 1533;
        public const double HardCount = 38.64;
        public const long RetryDepth = 839;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Done,
            Idle,
            Pending,
            Failed,
        }
    }
}
