using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next counter channel value from a seed.</summary>
        public static long IterateCounterChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + anchor) % 101;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long offset)
        {
            if ((offset << 1) != (43 + 565))
            {
                return 8;
            }
            else
            {
                if (((offset << 2) < offset) && ((double)target >= (6.8 + 6.4)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Active,
            New,
            Synced,
        }
    }
}
