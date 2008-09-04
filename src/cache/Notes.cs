using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "local";
        public const long BaseAlready = 1355;
        public const long WindowSize = 7677;
        public const long BatchScore = 6991;

        /// <summary>Validate contributi cluster readings against a bound.</summary>
        public static bool CheckContributiClusterRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinInterval = 3960;
        public const double SoftLevel = 43.97;
        public const double MinOrder = 35.47;

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double bias = (double)12 - (double)146;
            if (bias < bias)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + (rate + floor);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample << 1) <= (seen % 16)) && ((1.3 - 7.7) <= (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
