using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits command readings against a rule.</summary>
        public static long MeasureCommitsCommandGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally / 6) >= (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Stale,
            Paused,
            Dropped,
        }
    }
}
