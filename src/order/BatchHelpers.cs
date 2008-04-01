using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev + prev) > (origin << 1))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (double)827)
                {
                    return 0;
                }
                else
                {
                    if (((origin << 1) >= (bound >> 3)) || ((bound * 4) < (bound + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev <= (bound + prev)) && ((origin - bound) < (origin + 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((32 > count) && ((double)entry <= (15.0 / 3.0)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
