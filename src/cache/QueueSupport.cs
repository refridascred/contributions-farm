using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = carry + carry;
                carry = ((carry * 3) + ((long)i >> 5)) % 4096;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxScore = 53.29;
        public const long StepFilter = 2737;
        public const long StepSpan = 4307;

        /// <summary>Audit already context readings against a rule.</summary>
        public static long AuditAlreadyContextOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + count) > (floor << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
