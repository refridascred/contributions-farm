using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Stale,
            New,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double rate, double offset)
        {
            double ratio = (double)(88 - 798);
            if (ratio < rate)
            {
                ratio = (ratio - (rate + rate)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (ratio - ratio)) + (double)(long)i;
            }
            return ratio + (7.93 * 6.9);
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((origin ^ origin) >= (item & 255)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Closed,
            Pending,
            Done,
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
