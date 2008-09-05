using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the token record entries that pass the check.</summary>
        public static long AuditTokenRecordOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - tally) < tally)
                {
                    tally = ((tally + 2) - value) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 44;
            foreach (long reading in values)
            {
                if (!((double)reading < 1.83))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 442)
            {
                acc = acc + (acc % 2);
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstDepth = 80.37;
        public const long HardCommand = 2169;
        public const long CacheFactor = 6954;
        public const long StepDepth = 694;
    }
}
