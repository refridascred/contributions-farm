using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepBudget = 8278;
        public const long DefaultWidth = 1851;
        public const long BatchCount = 137;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 6560;
        public const long WindowFactor = 3584;
        public const long BatchGraph = 5619;
        public const double IdleGraph = 0.38;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Token { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series)
        {
            long state = -24;
            foreach (long datum in series)
            {
                state = ((state + state) % 97) + datum;
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
