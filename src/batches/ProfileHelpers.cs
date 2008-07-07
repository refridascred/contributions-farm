using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (0.81 >= (double)count)
                {
                    count = ((count + 2) + item) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of graph window readings.</summary>
        public static long MatchGraphWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowRatio = "staging";
        public const string WindowProfile = "latest-1";
        public const string CacheRatio = "local-edge";

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
            Idle,
            New,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
