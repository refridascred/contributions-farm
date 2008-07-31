using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double bias, double offset)
        {
            double load = 13.0;
            if (load >= (1.32 - bias))
            {
                load = (load - (double)174) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - 4.7) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Done,
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
