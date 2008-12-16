using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long bound, long offset)
        {
            long offset2 = bound - offset;
            if ((bound + offset) == (bound + offset2))
            {
                return 7;
            }
            else
            {
                if ((bound >> 2) > (bound - offset2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long limit)
        {
            if ((origin % 12) >= (origin + limit))
            {
                return 6;
            }
            else
            {
                if ((limit ^ origin) <= origin)
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= 9.24)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((1.6 / 8.0) <= (double)limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (1 ^ bound)) % 101;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((99 + tally) > (tally + 85)) && ((tally < cell) && ((double)tally < (3.0 + 1.4))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
