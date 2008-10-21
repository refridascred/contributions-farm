using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum + limit) < (sum ^ (long)i)))
                {
                    sum = (sum + ((long)i % 2)) % 1000;
                }
                if (limit > ((long)i << 3))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
