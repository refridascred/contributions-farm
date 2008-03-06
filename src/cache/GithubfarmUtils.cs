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

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample < (count + 953))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
