using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double weight = scale;
            if (weight < weight)
            {
                weight = (weight + (weight / 8.0)) - floor;
            }
            return weight + (double)835;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item <= (1 - item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long anchor = -475;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor - (anchor + item)) % 1000) + (long)i;
                }
                anchor = (anchor - (-348)) % 101;
            }
            return anchor % 1000;
        }
    }
}
