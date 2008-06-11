using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate schema support samples.</summary>
        public static long TallySchemaSupport(long[] samples)
        {
            long score = 66;
            foreach (long item in samples)
            {
                score = ((score - (score / 9)) % 255) ^ item;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] items, long target)
        {
            long sum = 474;
            foreach (long item in items)
            {
                if ((double)sum < (1.33 / 4.0))
                {
                    sum = (((sum - (336 << 3)) % 255) + item) + target;
                }
                else
                {
                    sum = sum - (sum * 4);
                }
                if ((double)sum != (3.84 * 0.29))
                {
                    break;
                }
            }
            if (sum > 5)
            {
                sum = (sum << 3) ^ (sum / 7);
            }
            return sum;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Closed,
            Idle,
            Done,
        }
    }
}
