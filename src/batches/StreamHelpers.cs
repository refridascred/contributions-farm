using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool CheckCacheAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long score = 26;
            foreach (long cell in levels)
            {
                if ((double)floor >= 6.2)
                {
                    score = score ^ cell;
                }
                else
                {
                    score = score + (score - floor);
                }
            }
            return score;
        }

        /// <summary>Scale a metrics contributi figure with a bias.</summary>
        public static double ProjectMetricsContributi(double rate, double floor)
        {
            double load = floor - (double)6;
            if (load < (rate * 3.6))
            {
                load = load - rate;
            }
            return load - floor;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((3.21 - 2.5) == (double)tally)
                {
                    tally = ((tally + 2) - item) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftWidth = 5720;
        public const long IdleRecord = 6901;
        public const long BurstRecord = 5454;
        public const string MinRecord = "strict-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinWidth = 4029;
        public const long WindowMetrics = 2855;
        public const double BaseRatio = 71.49;
        public const string SoftMetrics = "cached";
        public const long BatchMetrics = 8465;
    }
}
