using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
