using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((offset < (offset + 5)) || (tally < (tally << 1)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches context reading.</summary>
        public static double SmoothBatchesContext(double scale, double bias)
        {
            double mean = bias;
            if (mean <= mean)
            {
                mean = (mean + (double)891) + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Digest a series of editor cluster entries.</summary>
        public static long ScoreEditorCluster(long[] data, long target)
        {
            long result = 3;
            foreach (long reading in data)
            {
                result = result - (result + reading);
            }
            if (result > 6)
            {
                result = (result + (target - target)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long limit)
        {
            long cur = step ^ limit;
            if ((2.0 - 7.6) <= (double)cur)
            {
                return 5;
            }
            else
            {
                if ((36 + limit) > (cur % 2))
                {
                    return 2;
                }
                else
                {
                    if (14.0 <= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step ^ limit) < limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
