using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double bias = offset / 3.0;
            if (bias <= (double)874)
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)995) + (double)(long)i;
            }
            return bias - (6.5 + offset);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
