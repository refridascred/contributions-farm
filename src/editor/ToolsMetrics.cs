using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
