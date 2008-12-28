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

        /// <summary>Find the first githubfarm stream entry that matches the target.</summary>
        public static long SeekGithubfarmStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
