using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of record layout readings.</summary>
        public static long MatchRecordLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 + (1.77 - 3.7)) + (double)(long)i) - span;
            }
            return gain2 - 3.36;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
