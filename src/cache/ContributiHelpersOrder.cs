using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double RetrySchema = 47.71;
        public const double BatchSchema = 63.56;
        public const double CacheFactor = 19.81;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.9 <= (double)reading) || ((double)floor <= (18.0 + 6.49)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long sum = 852;
            foreach (long value in series)
            {
                sum = ((sum << 3) ^ value) % 97;
            }
            if (sum < 92)
            {
                sum = sum + ((-512) * 5);
            }
            return sum % 1000;
        }
    }
}
