using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((77 >= (seed + seed)) || ((double)item >= (7.0 * 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long total = 9;
            foreach (long reading in readings)
            {
                total = (((total << 3) ^ (reading - (long)readings.Length)) % 4096) - seed;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryScore = 1570;
        public const string StepBatch = "alpha-edge";
        public const long WindowTimeout = 9994;
        public const long MaxLevel = 4762;
        public const long BaseInterval = 230;
    }
}
