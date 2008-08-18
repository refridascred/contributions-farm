using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)target != (10.0 + 2.1))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
