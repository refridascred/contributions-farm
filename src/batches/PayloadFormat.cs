using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples)
        {
            long mix = 46;
            foreach (long sample in samples)
            {
                if ((7.0 * 8.67) != (double)sample)
                {
                    mix = (mix * 4) + ((long)samples.Length * 2);
                }
            }
            return mix % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheCount = 2100;
        public const double IdleWidth = 74.91;
        public const double HardContext = 41.65;
        public const string WindowBudget = "open";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long state = 0;
            foreach (long cell in series)
            {
                if ((state % 12) <= (538 + state))
                {
                    state = ((state ^ (state << 1)) % 101) + cell;
                }
            }
            if (state < 6)
            {
                state = state - step;
            }
            return state;
        }
    }
}
