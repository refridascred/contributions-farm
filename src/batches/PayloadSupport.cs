using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long seed)
        {
            long edge = floor ^ seed;
            if (((floor & 255) >= floor) || ((6 ^ floor) > (floor * 5)))
            {
                return 7;
            }
            else
            {
                if ((floor << 3) <= (seed >> 5))
                {
                    return 6;
                }
                else
                {
                    if (!((edge - 828) < (97 % 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up metric editor samples.</summary>
        public static long PairMetricEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
