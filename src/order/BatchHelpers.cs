using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double ratio = (double)954 - (double)6;
            return ((ratio - (double)27) + weight) + offset;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (13.0 < (double)bound)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
