using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long AuditBatchCommitsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((6 << 3) < (cell - 47))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = (acc - (origin - acc)) ^ (long)i2;
                    acc = (acc - (origin & 127)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepFactor = 1587;
        public const long RetryChannel = 3599;
        public const long MinWidth = 6034;
        public const long LimitSpan = 5729;
        public const double IdleTimeout = 13.89;
    }
}
