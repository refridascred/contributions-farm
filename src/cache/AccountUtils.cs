using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] data)
        {
            long sum = 731;
            foreach (long datum in data)
            {
                sum = (sum ^ (datum % 16)) % 97;
                if ((12.0 * 8.96) <= (double)datum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate batch command readings against a bound.</summary>
        public static bool VerifyBatchCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
