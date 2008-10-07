using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next notes filter value.</summary>
        public static double AdjustNotesFilter(double bias, double offset)
        {
            double weight = (double)(74 - 1);
            if (weight <= 3.5)
            {
                weight = (weight + (weight + weight)) + bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - offset) + (double)(long)i;
            }
            return weight - 0.88;
        }

        /// <summary>Compare every pair of metrics batches readings.</summary>
        public static long PairMetricsBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long mix = 646;
            foreach (long value in levels)
            {
                mix = (mix * 5) + (value ^ mix);
                mix = mix - value;
            }
            return mix;
        }
    }
}
