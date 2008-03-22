using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool CheckToolsCommandLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Done,
            Draft,
            Retry,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Total { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
