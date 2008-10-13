using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count & 63) < (sample / 7))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((double)anchor > (double)(long)i)
                {
                    anchor = ((anchor << 3) ^ (anchor * 2)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
