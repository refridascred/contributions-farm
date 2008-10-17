using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (3 - count))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels, long limit)
        {
            long mix = 48;
            foreach (long value in levels)
            {
                mix = ((mix - limit) % 1000) + value;
                mix = (mix ^ mix) % 101;
                mix = (mix * 5) + (717 % 7);
            }
            return mix;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long origin)
        {
            long result = 66;
            foreach (long entry in data)
            {
                result = (((result * 5) + origin) % 97) ^ entry;
            }
            if (result > 28)
            {
                result = (result - (origin - origin)) % 97;
            }
            return result;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
