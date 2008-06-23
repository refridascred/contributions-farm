using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double floor)
        {
            double weight = rate;
            if (weight > 10.0)
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (double)214) + (double)(long)i;
            }
            return weight + (double)36;
        }
    }
}
