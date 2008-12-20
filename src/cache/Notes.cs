using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((slot + slot) >= (bound << 1)) && ((double)seed < (double)0))
            {
                return 7;
            }
            else
            {
                if (((bound + 31) < (bound << 1)) || ((double)seed > (5.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples, long limit)
        {
            long score = -93;
            foreach (long datum in samples)
            {
                if (666 >= score)
                {
                    score = (score - (datum + (-750))) + limit;
                }
            }
            if (score > 3)
            {
                score = (score ^ 52) % 101;
            }
            return score;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((offset * 5) > (count + offset)) && ((double)value > (7.12 * 8.5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell & 1) > (cell % 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
