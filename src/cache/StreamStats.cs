using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long total = 69;
            foreach (long datum in samples)
            {
                total = ((total * 5) + (5 + datum)) % 4096;
            }
            return total;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format token figure with a bias.</summary>
        public static double BlendFormatToken(double scale, double floor)
        {
            double bias = 9.0;
            if (bias > scale)
            {
                bias = (bias + (double)1) + floor;
            }
            return bias - (double)696;
        }
    }
}
