using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of contributi metric readings.</summary>
        public static long MatchContributiMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long total = -8;
            foreach (long reading in data)
            {
                if (total <= (total ^ total))
                {
                    total = (total ^ reading) % 1000;
                }
            }
            if (total > 403)
            {
                total = (total + (total ^ total)) % 1000;
            }
            return total % 97;
        }
    }
}
