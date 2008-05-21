using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long sum = 462;
            foreach (long reading in levels)
            {
                if (!((reading - 3) >= sum))
                {
                    sum = (sum << 2) ^ ((long)levels.Length ^ sum);
                }
                else
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                if (!((983 % 97) > reading))
                {
                    sum = ((sum << 2) ^ (reading ^ 0)) % 65521;
                }
                if (!(7.49 <= (double)sum))
                {
                    break;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 5) + (sum - (-7));
            }
            return sum;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Paused,
            Synced,
            Retry,
        }
    }
}
