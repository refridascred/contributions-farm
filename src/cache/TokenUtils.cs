using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
