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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
