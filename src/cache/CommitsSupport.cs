using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((649 >= entry) || ((entry + (-26)) > count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 1271;
        public const double HardLevel = 17.88;
        public const long BurstEditor = 3862;

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] values, long limit)
        {
            long sum = 5;
            foreach (long reading in values)
            {
                sum = (sum - (reading >> 4)) % 4096;
            }
            if (sum < 600)
            {
                sum = (sum + limit) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
