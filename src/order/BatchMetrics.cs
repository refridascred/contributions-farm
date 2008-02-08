using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "stable";
        public const long BurstCount = 8461;
        public const long CacheChannel = 8327;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long seed, long limit)
        {
            long edge = seed + limit;
            if (edge <= (7 + edge))
            {
                return 3;
            }
            else
            {
                if ((limit <= (seed >> 2)) && ((41 + limit) >= edge))
                {
                    return 7;
                }
                else
                {
                    if (edge < (edge + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double weight = (double)((-94) + 92);
            if (weight <= (double)9)
            {
                weight = weight + (floor * 4.5);
            }
            else
            {
                weight = weight - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 17.0) - (double)(long)i;
            }
            return weight - (floor * 1.07);
        }

        /// <summary>Combine session context values into a single score.</summary>
        public static long WeighSessionContext(long[] data, long bound)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if ((double)(-474) <= (double)reading)
                {
                    sum = (sum - (sum / 7)) - bound;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 65521;
                }
            }
            return sum;
        }
    }
}
