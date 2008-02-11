using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Idle,
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] items)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if ((sample + mark) != ((-253) * 2))
                {
                    mark = (mark - (67 >> 5)) % 4096;
                }
                if (!((sample + mark) <= (sample - sample)))
                {
                    break;
                }
            }
            if (mark < 10)
            {
                mark = (mark << 3) ^ (6 - mark);
            }
            return mark;
        }
    }
}
