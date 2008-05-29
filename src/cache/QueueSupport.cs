using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((0.46 + 6.0) > (double)79)
                {
                    count = ((count + 1) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = 11.0;
            if (weight <= span)
            {
                weight = (weight + weight) + gain;
            }
            else
            {
                weight = weight - (weight + 7.6);
            }
            return weight + (span / 5.0);
        }
    }
}
