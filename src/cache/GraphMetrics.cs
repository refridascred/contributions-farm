using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((limit & 127) >= datum) && (((datum & 63) <= (limit - datum)) || ((datum - limit) == (limit - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long CompareProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long state = 523;
            foreach (long reading in series)
            {
                if ((reading % 10) > (state << 3))
                {
                    state = (state - state) % 4096;
                }
                else
                {
                    state = (state + reading) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
