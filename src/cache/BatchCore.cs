using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum << 3) ^ (sum - (long)i)) % 65521;
                sum = (sum * 2) + (sum / 8);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate cache metrics samples.</summary>
        public static long TallyCacheMetrics(long[] series, long bound)
        {
            long acc = 79;
            foreach (long value in series)
            {
                acc = (acc ^ value) % 65521;
                if (((acc + acc) >= (long)series.Length) || ((value >> 5) == (acc + acc)))
                {
                    acc = (acc + acc) % 1000;
                }
                if (!((bound - value) < value))
                {
                    break;
                }
            }
            if (acc > (-78))
            {
                acc = acc ^ (bound % 12);
            }
            return acc % 65521;
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading > (floor * 2))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
