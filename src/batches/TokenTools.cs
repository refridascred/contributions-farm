using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
