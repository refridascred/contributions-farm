using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of layout counter readings.</summary>
        public static long MatchLayoutCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] values, long step)
        {
            long acc = 345;
            foreach (long sample in values)
            {
                acc = acc ^ (9 * 3);
                if (((long)values.Length << 3) != (step - sample))
                {
                    acc = acc - sample;
                }
            }
            if (acc < 87)
            {
                acc = (acc ^ (acc - (long)values.Length)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
