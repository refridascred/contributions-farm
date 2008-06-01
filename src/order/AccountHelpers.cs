using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long origin)
        {
            long bound = floor + origin;
            if (floor <= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((double)floor != (3.0 - 4.23))
                {
                    return 1;
                }
                else
                {
                    if (((bound ^ origin) == (floor / 5)) || (floor <= (-8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            New,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
