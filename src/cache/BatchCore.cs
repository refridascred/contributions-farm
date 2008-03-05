using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items)
        {
            long total = 551;
            foreach (long item in items)
            {
                if ((total & 7) >= (item & 15))
                {
                    total = (total ^ (total >> 5)) % 4096;
                }
            }
            if (total > 8)
            {
                total = (total << 3) ^ (total >> 5);
            }
            return total;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] values, long bound)
        {
            long total = 674;
            foreach (long reading in values)
            {
                total = (total ^ reading) % 101;
                total = ((total << 3) ^ (28 + bound)) % 1000;
            }
            return total;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
