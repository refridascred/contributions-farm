using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seed == (0.6 / 8.0))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long acc = 9;
            foreach (long reading in items)
            {
                if ((reading % 8) < reading)
                {
                    acc = acc - (99 + acc);
                }
            }
            return acc;
        }

        /// <summary>Scale a already support figure with a bias.</summary>
        public static double ProjectAlreadySupport(double scale, double floor)
        {
            double bias = floor;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - floor) - (double)(long)i) + scale;
            }
            return bias + (double)(-48);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 6689;
        public const string SoftCount = "primary-v2";
        public const double LimitStats = 90.34;
        public const long BurstInterval = 1157;
        public const double HardStats = 53.37;
    }
}
