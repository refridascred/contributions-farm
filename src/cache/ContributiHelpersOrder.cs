using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 2212;
        public const long DefaultLayout = 2491;
        public const long BatchSize = 3757;
        public const double BatchLayout = 35.72;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - tally) > (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((reading >> 1) > (reading ^ target)) && (((0.6 * 6.5) != (double)reading) || ((target / 7) >= (reading >> 2))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
