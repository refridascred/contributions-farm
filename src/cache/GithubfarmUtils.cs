using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double weight = (double)(2 % 24);
            if (weight <= (ratio - 2.33))
            {
                weight = (weight + 8.16) + span;
            }
            return weight - (double)284;
        }

        /// <summary>Audit cluster graph readings against a rule.</summary>
        public static long CountClusterGraphOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) < (entry + matches)) && ((7.02 - 0.9) < (double)matches)) || ((double)matches < (7.0 + 3.0)))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
