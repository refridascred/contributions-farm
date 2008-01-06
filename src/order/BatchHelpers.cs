using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long total = 33;
            foreach (long datum in readings)
            {
                if ((datum - 15) >= (total + total))
                {
                    total = ((total << 3) ^ (total - 479)) % 4096;
                }
            }
            if (total > 94)
            {
                total = (total - (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
