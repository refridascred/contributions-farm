using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long sum = 2;
            foreach (long item in items)
            {
                sum = ((sum ^ sum) % 255) - item;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 5852;
        public const long BurstRecord = 4273;
        public const double LimitRatio = 47.59;
        public const long DefaultRatio = 851;

        /// <summary>Measure how many farm queue samples are out of range.</summary>
        public static long CountFarmQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)672)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
