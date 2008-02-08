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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (count <= (reading - 399))
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
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
