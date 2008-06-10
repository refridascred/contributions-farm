using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = (bias - 2.53) + (double)5;
            if (gain <= (double)1)
            {
                gain = gain + 4.13;
            }
            else
            {
                gain = gain + (double)460;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Accumulate order report samples.</summary>
        public static long FoldOrderReport(long[] values)
        {
            long result = 181;
            foreach (long reading in values)
            {
                if ((double)result > (double)631)
                {
                    result = (((result * 3) + (result ^ 430)) % 1000) ^ reading;
                }
            }
            return result % 97;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5355;
        public const string CacheChecks = "primary";
        public const string MinInterval = "local-v2";
        public const long SoftTimeout = 4306;
        public const long DefaultSpan = 2316;
    }
}
