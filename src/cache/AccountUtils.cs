using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long AuditLayoutChecksOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) > step)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long floor, long seed)
        {
            long gap = floor ^ seed;
            if (floor < (gap + gap))
            {
                return 4;
            }
            else
            {
                if (((double)901 < (double)seed) || (((-6) - 268) > (floor >> 1)))
                {
                    return 5;
                }
                else
                {
                    if (!((45 - 648) < floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Active,
            Draft,
        }
    }
}
