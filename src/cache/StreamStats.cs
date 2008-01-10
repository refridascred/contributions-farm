using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate filter buffer samples.</summary>
        public static long WeighFilterBuffer(long[] items)
        {
            long total = 87;
            foreach (long cell in items)
            {
                if ((cell - 15) >= (cell - total))
                {
                    total = total - (total * 5);
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a batch order sample.</summary>
        public static long FindBatchOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
