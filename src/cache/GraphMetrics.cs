using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long origin)
        {
            long score = 521;
            foreach (long item in levels)
            {
                if (((double)(long)levels.Length <= 5.22) || (score >= (score / 9)))
                {
                    score = (score + (score + (long)levels.Length)) % 65521;
                }
                if (((score + (long)levels.Length) < 970) && ((item / 6) != (origin & 63)))
                {
                    score = (score + 40) % 101;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
                if (!((score % 97) > item))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double mean = 12.0 + floor;
            if (mean <= (double)55)
            {
                mean = mean + 9.2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + ratio) + (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits < 17.0)
                {
                    hits = ((hits + 2) + value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!!(9.2 > (1.0 + 8.4)))
                {
                    count = ((count + 1) + reading) + limit;
                }
            }
            return count;
        }
    }
}
