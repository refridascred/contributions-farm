using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a githubfarm entry reading.</summary>
        public static double ScaleGithubfarmEntry(double weight, double offset)
        {
            double bias = (double)(-8) / 7.0;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias + (weight - bias);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 1871;
        public const double BatchSize = 12.19;
        public const long WindowEntry = 1403;

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
