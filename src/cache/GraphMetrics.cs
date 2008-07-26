using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = score ^ (origin >> 5);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double gain, double span)
        {
            double scale = span;
            if (scale < span)
            {
                scale = (scale - span) + gain;
            }
            else
            {
                scale = scale + (span / 9.0);
            }
            return scale - (span + 8.3);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((double)seed < (double)matches) && ((entry + 296) >= (seed / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long seed2)
        {
            if ((seed - seed) < seed2)
            {
                return 8;
            }
            else
            {
                if ((double)seed2 > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double gain = (2.9 - rate) + (span - span);
            if (gain >= span)
            {
                gain = gain - (rate * 6.1);
            }
            else
            {
                gain = gain - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
