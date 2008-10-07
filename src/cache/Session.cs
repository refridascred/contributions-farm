using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
