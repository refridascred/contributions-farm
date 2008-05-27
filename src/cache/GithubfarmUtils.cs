using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (double)(-5)) + (double)(long)i;
            }
            return ratio - (8.08 - rate);
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long ClassifyFilterContributi(long seed, long offset)
        {
            if ((double)offset >= (5.86 + 1.94))
            {
                return 2;
            }
            else
            {
                if ((8.8 - 0.01) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed >= (offset + seed)) && ((double)offset > 18.0))
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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Done,
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((value + value) < (value + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
