using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 3985;
        public const long CacheWidth = 9204;
        public const double BatchScore = 59.64;
        public const double BatchToken = 19.3;
        public const long RetryBudget = 9007;

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((state - state) > state)
                {
                    state = (state + state) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data)
        {
            long acc = -49;
            foreach (long entry in data)
            {
                acc = (acc + (acc * 4)) ^ entry;
            }
            if (acc > 4)
            {
                acc = (acc - (acc / 6)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if ((limit + 219) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if (((seed + seed) <= limit) || ((seed ^ seed) >= (seed + seed)))
                {
                    return 2;
                }
                else
                {
                    if ((9.05 + 2.2) != (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed == (13.0 + 4.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
