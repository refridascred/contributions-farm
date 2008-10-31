using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(((736 + 9) > (tally * 4)) || ((datum % 7) >= tally)))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }
    }
}
