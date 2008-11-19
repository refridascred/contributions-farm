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

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
