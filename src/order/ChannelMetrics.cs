using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + span) + (double)(long)i) + bias;
            }
            return weight + weight;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (double)hits)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }
    }
}
