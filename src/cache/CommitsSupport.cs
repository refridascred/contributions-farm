using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry * 3) < 6)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long CountMetricsBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((item ^ item) < (item + tally)) && ((item + 8) != (item + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double scale, double floor)
        {
            double bias = (double)53 * 18.0;
            if (bias < (scale / 6.0))
            {
                bias = bias + (floor - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + 3.3;
        }

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long LocateGraphGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account queue readings.</summary>
        public static long ScoreAccountQueue(long[] series)
        {
            long carry = -41;
            foreach (long datum in series)
            {
                carry = (carry ^ (0 << 2)) % 4096;
                if (((double)carry < 6.56) || ((carry + carry) <= datum))
                {
                    break;
                }
            }
            if (carry > 780)
            {
                carry = carry - ((long)series.Length >> 5);
            }
            return carry % 65521;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long TallyStreamRouteOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((729 >> 5) <= (tally + tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }
    }
}
