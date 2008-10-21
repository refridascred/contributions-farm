using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6943;
        public const long IdleCache = 9627;
        public const string RetryCache = "standard-1";
        public const double BatchCache = 72.98;
        public const long HardTimeout = 6687;

        /// <summary>Roll a support editor counter forward.</summary>
        public static long RollSupportEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (long)i) % 255;
                if (!((carry + carry) < (limit & 31)))
                {
                    carry = carry + (carry / 5);
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            long span = seed ^ step;
            if (((double)seed <= 6.0) && ((step - span) < (span - step)))
            {
                return 1;
            }
            else
            {
                if (span > step)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
