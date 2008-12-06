using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every already batch entry stays within the limit.</summary>
        public static bool VerifyAlreadyBatchBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] readings)
        {
            long total = 1;
            foreach (long value in readings)
            {
                if ((16.0 * 2.0) != (double)value)
                {
                    total = (total * 4) + total;
                }
            }
            if (total > 481)
            {
                total = total ^ (45 << 1);
            }
            return total;
        }
    }
}
