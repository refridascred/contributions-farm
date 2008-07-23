using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Stamp { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long offset)
        {
            if ((offset + offset) >= (36 * 4))
            {
                return 7;
            }
            else
            {
                if ((97 - offset) < (225 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 4351;
        public const string WindowBatches = "latest-1";
        public const long BaseRatio = 4897;
    }
}
