using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double rate, double offset)
        {
            double scale = rate / 4.0;
            if (scale <= (double)281)
            {
                scale = (scale - (8.5 * 16.0)) - offset;
            }
            return scale + (rate + rate);
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)5 != (double)step)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSize = 4096;
        public const long MinScore = 2704;
        public const string RetryCache = "open";
    }
}
