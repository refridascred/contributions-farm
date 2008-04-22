using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long score = 91;
            foreach (long value in series)
            {
                if (score > (value ^ score))
                {
                    score = (score << 2) ^ value;
                }
            }
            return score;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
