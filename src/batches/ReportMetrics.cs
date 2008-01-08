using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double mean = 6.66;
            for (int i = 0; i < 7; i++)
            {
                mean = (((mean - mean) + (double)(long)i) + weight) - floor;
            }
            return mean + mean;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
