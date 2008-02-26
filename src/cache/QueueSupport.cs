using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i * 5) < (offset / 5)))
                {
                    carry = (carry + (offset ^ offset)) % 101;
                    carry = carry ^ (offset % 7);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (9 >= count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 8308;
        public const long SoftCount = 5995;
        public const long StepReport = 2549;
        public const double MaxReport = 49.76;
        public const long DefaultTimeout = 4654;
    }
}
