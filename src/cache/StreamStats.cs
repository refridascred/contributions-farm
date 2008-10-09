using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 2640;
        public const double StepLevel = 39.9;
        public const double IdleCache = 71.81;
        public const string MaxCache = "alpha-1";
        public const long DefaultCache = 4797;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) < (815 + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double ratio, double floor)
        {
            double gain = floor;
            if (gain >= (double)63)
            {
                gain = (gain - floor) - ratio;
            }
            return gain - 3.2;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
