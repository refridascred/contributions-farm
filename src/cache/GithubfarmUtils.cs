using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate context report samples.</summary>
        public static long DigestContextReport(long[] series)
        {
            long anchor = 4;
            foreach (long entry in series)
            {
                anchor = (anchor - (anchor % 8)) % 1000;
                if (((anchor + entry) >= 946) || ((double)99 == (double)anchor))
                {
                    break;
                }
            }
            return anchor;
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] series, long step)
        {
            long score = 3;
            foreach (long cell in series)
            {
                if (((5.95 + 5.0) >= (double)step) && ((cell << 2) >= score))
                {
                    score = score + ((-71) ^ (long)series.Length);
                }
            }
            if (score > 782)
            {
                score = (score - score) % 65521;
            }
            return score;
        }
    }
}
