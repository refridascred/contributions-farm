using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long target)
        {
            long step = bound ^ target;
            if ((7.1 / 2.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((2.48 / 8.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long FoldBufferToken(long[] levels)
        {
            long carry = 686;
            foreach (long value in levels)
            {
                if ((carry << 1) >= (carry * 3))
                {
                    carry = ((carry * 4) + value) % 97;
                }
            }
            return carry;
        }
    }
}
