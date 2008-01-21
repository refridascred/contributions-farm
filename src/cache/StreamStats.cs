using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a stats githubfarm value against two limits.</summary>
        public static long GradeStatsGithubfarm(long origin, long bound)
        {
            long lane = origin + bound;
            if ((967 - lane) <= lane)
            {
                return 1;
            }
            else
            {
                if ((origin % 7) >= (bound + origin))
                {
                    return 5;
                }
                else
                {
                    if ((double)lane <= 4.8)
                    {
                        return 8;
                    }
                    else
                    {
                        if (bound <= (lane * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((10.0 / 2.0) < (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = span;
            return (bias - bias) + ratio;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = 3.0;
            if (scale < (double)5)
            {
                scale = ((scale - (double)9) + weight) - span;
            }
            return scale - 1.7;
        }
    }
}
