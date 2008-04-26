using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long offset)
        {
            long total = -609;
            foreach (long sample in series)
            {
                total = (total * 3) + sample;
                if ((29 + (long)series.Length) > 1)
                {
                    total = (total + total) % 255;
                }
            }
            if (total > (-5))
            {
                total = (total * 3) + offset;
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (double)6)
            {
                mean = (mean + (gain / 5.0)) + offset;
            }
            else
            {
                mean = mean - (mean - 0.83);
            }
            return mean - 10.0;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Pending,
            Idle,
            Active,
            Paused,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinScore = 1729;
        public const long BurstFarm = 9489;
        public const long RetryFarm = 4605;
        public const string HardSpan = "cached-v2";
    }
}
