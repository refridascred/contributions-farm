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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long step)
        {
            if (bound < (step ^ (-161)))
            {
                return 5;
            }
            else
            {
                if ((8.0 / 2.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
