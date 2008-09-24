using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7855;
        public const long LimitRoute = 9612;
        public const string DefaultCount = "alpha-v2";

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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long state = 17;
            foreach (long reading in values)
            {
                state = ((state + (state & 7)) % 1000) ^ reading;
            }
            if (state > 61)
            {
                state = (state + (state - 406)) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + limit) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
