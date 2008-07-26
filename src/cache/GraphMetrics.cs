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

        /// <summary>Count the filter editor entries that pass the check.</summary>
        public static long CountFilterEditorMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)325 == (double)target)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
