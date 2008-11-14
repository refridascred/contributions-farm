using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 70.81;
        public const long IdleEntry = 8676;
        public const long LimitCount = 5810;
        public const long BatchSize = 780;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (8.6 + 6.2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long value in readings)
            {
                if ((value & 15) <= (limit >> 5))
                {
                    sum = (sum ^ (limit + limit)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (13 % 3)) % 255;
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ (limit * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = result + result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
