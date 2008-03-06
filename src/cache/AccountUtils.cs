using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 6455;
        public const double RetryTimeout = 72.63;
        public const double HardContributi = 72.23;

        /// <summary>Audit editor tools readings against a rule.</summary>
        public static long TallyEditorToolsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(origin > (count & 3)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Measure how many order context samples are out of range.</summary>
        public static long TallyOrderContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally >= (676 + tally))
                {
                    tally = ((tally + 1) + sample) + floor;
                }
            }
            return tally;
        }
    }
}
