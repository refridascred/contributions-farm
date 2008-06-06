using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4970;
        public const long StepCounter = 2927;
        public const double BatchCounter = 88.18;
        public const long LimitCounter = 1333;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) > 202)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
