using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Synced,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            if (((bound - floor) <= (79 * 2)) || ((floor / 5) <= bound))
            {
                return 7;
            }
            else
            {
                if ((floor * 3) == (floor + bound))
                {
                    return 6;
                }
                else
                {
                    if (floor > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor != (3.8 + 4.17))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
