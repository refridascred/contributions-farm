using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long step, long floor)
        {
            long bound = step - floor;
            if ((double)floor == (5.2 + 20.0))
            {
                return 3;
            }
            else
            {
                if ((((-90) - bound) == (floor + step)) || ((bound + step) < (86 << 2)))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (floor & 15))
                    {
                        return 5;
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
