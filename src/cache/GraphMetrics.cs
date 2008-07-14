using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Scale a report layout figure with a bias.</summary>
        public static double SmoothReportLayout(double rate, double span)
        {
            double gain = (span / 8.0) * 7.08;
            if (gain <= (span + gain))
            {
                gain = gain - (gain - gain);
            }
            else
            {
                gain = gain - rate;
            }
            return gain + (span + 1.1);
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((tally + entry) < (25 - tally)) && ((double)entry > (5.74 * 9.3))) || ((tally % 3) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
