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

        /// <summary>Derive the next batch contributi value from a seed.</summary>
        public static long SeriesBatchContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + ((long)i / 8)) % 65521;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
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
