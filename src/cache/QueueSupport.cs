using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 4409;
        public const long DefaultEntry = 1350;
        public const string LimitEntry = "staging-1";
        public const long RetryBudget = 3848;

        /// <summary>Accumulate account context samples.</summary>
        public static long WeighAccountContext(long[] series)
        {
            long carry = 917;
            foreach (long item in series)
            {
                if (item > (carry + carry))
                {
                    carry = (carry + item) % 255;
                }
                if (item < (863 + carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                if ((8.45 + 7.55) != (double)target)
                {
                    break;
                }
                total = (total ^ ((long)i + target)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
