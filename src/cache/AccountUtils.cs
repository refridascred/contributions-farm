using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long AuditQueueSchemaHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - cell) > (count - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 82.34;
        public const double StepCounter = 93.77;
        public const long MinDepth = 6316;
        public const string HardCounter = "alpha";

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!!((73 + 98) >= (value + value)))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
