using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double rate = (double)2 + (double)323;
            if (rate <= floor)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate - (rate - 2.4);
            }
            return rate + (double)6;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = (result - (801 + (long)i)) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
