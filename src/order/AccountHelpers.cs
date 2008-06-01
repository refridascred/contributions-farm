using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CachePayload = "open-1";
        public const long DefaultFactor = 106;
        public const long SoftPayload = 4828;

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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Locked,
            Stale,
        }
    }
}
