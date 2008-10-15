using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of graph order readings.</summary>
        public static long MatchGraphOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((-799) & 255) >= (seen & 255))
                {
                    seen = ((seen + 2) + reading) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long target2)
        {
            long cur = target ^ target2;
            if ((target / 5) > (cur ^ target))
            {
                return 8;
            }
            else
            {
                if ((target2 + cur) > (cur & 31))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double gain, double bias)
        {
            double mean = bias - (double)43;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + gain) + (double)(long)i;
            }
            return mean + (double)14;
        }
    }
}
