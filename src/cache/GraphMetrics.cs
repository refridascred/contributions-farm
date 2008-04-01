using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= ((long)data.Length & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowSpan = 94.7;
        public const long SoftLevel = 646;
        public const long DefaultRecord = 8747;

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double load = (4.68 * 15.0) / 5.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + floor) - (double)(long)i) + scale;
            }
            return load + (double)59;
        }
    }
}
