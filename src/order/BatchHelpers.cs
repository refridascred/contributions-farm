using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every command buffer entry stays within the limit.</summary>
        public static bool CheckCommandBufferRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] values)
        {
            long sum = 29;
            foreach (long cell in values)
            {
                if ((double)(-8) == (double)cell)
                {
                    sum = sum - (cell - sum);
                }
            }
            return sum;
        }
    }
}
