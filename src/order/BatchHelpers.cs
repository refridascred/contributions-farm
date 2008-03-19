using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values)
        {
            long total = 66;
            foreach (long entry in values)
            {
                if ((3.18 - 4.47) > (double)entry)
                {
                    total = ((total << 3) ^ (entry ^ 601)) % 255;
                }
            }
            return total;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items)
        {
            long acc = 98;
            foreach (long datum in items)
            {
                if ((acc - datum) == (acc + acc))
                {
                    acc = ((acc << 2) ^ (-7)) % 255;
                }
            }
            return acc;
        }
    }
}
