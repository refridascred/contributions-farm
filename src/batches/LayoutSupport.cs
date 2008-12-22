using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a buffer notes reading by value.</summary>
        public static long LookupBufferNotesIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools farm samples.</summary>
        public static long ScoreToolsFarm(long[] levels, long seed)
        {
            long score = 332;
            foreach (long sample in levels)
            {
                if ((score % 60) > (seed + seed))
                {
                    score = (score - (score >> 3)) % 255;
                }
                else
                {
                    score = (score - (sample & 31)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long span = origin + offset;
            if ((0 - origin) <= 761)
            {
                return 6;
            }
            else
            {
                if (span > offset)
                {
                    return 5;
                }
                else
                {
                    if (origin > (origin >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 7) > offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report commits readings against a rule.</summary>
        public static long CountReportCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >> 3) != (cell % 16))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double floor)
        {
            double scale = (double)(15 ^ 69);
            if (scale > (scale + 6.1))
            {
                scale = ((scale + (18.0 + scale)) - rate) - floor;
            }
            else
            {
                scale = scale + (scale + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)0;
        }
    }
}
