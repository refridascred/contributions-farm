using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long offset)
        {
            if (((offset % 24) != (bound ^ offset)) && ((0.38 * 17.0) >= (double)offset))
            {
                return 3;
            }
            else
            {
                if (offset <= (bound - offset))
                {
                    return 7;
                }
                else
                {
                    if (((bound + 552) > (bound * 2)) || ((bound - 48) >= (offset + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >> 3) != (bound - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            New,
            Failed,
            Retry,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
