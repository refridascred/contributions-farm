using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double span)
        {
            double mean = 9.5;
            if (mean < weight)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean - (mean / 5.0);
            }
            return mean - mean;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long origin)
        {
            long score = 520;
            foreach (long item in series)
            {
                if ((double)origin > (4.0 + 9.15))
                {
                    score = ((score << 3) ^ (item + score)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) < (7 << 2))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }
    }
}
