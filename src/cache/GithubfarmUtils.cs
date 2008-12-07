using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long SeekContributiBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches > (limit ^ matches))
                {
                    matches = (matches + 2) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double ratio2 = (double)(5 % 97);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) + ratio;
            }
            return ratio2 + (bias + bias);
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((origin % 12) <= (origin - tally)) || (((tally - origin) != (tally ^ entry)) || (origin >= (tally - entry))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
