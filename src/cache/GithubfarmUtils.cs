using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((double)tally <= (7.6 + 2.0)) && ((tally + cell) >= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = 2.33 / 4.0;
            if (ratio <= offset)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - bias;
        }

        /// <summary>Count the cluster route entries that pass the check.</summary>
        public static long TallyClusterRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((9 + item) > (hits % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
