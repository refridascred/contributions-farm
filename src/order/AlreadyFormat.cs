using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 9798;
        public const long WindowStream = 230;
        public const long HardInterval = 6732;
        public const double WindowFactor = 77.27;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm metric samples are out of range.</summary>
        public static long TallyGithubfarmMetricOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum < hits)
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Scale a support record figure with a bias.</summary>
        public static double ProjectSupportRecord(double rate, double span)
        {
            double drift = span;
            if (drift < (double)440)
            {
                drift = drift - 6.0;
            }
            else
            {
                drift = drift + (rate + drift);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (double)880;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
