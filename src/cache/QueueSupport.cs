using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((594 >> 2) == (sample * 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats commits pair into a bucket.</summary>
        public static long RankStatsCommits(long floor, long bound)
        {
            long edge = floor - bound;
            if (floor <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if (((floor * 2) < edge) && ((double)floor < (5.7 * 14.0)))
                {
                    return 1;
                }
                else
                {
                    if ((edge + bound) > (floor + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double scale = (double)(-9) * 3.63;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale + ratio) + (double)(long)i) - floor;
            }
            return scale - (4.3 * 8.0);
        }
    }
}
