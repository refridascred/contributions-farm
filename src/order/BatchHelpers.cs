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

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double weight = (double)(810 / 2);
            return ((weight + 17.0) + scale) + offset;
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
