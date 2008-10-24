using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((17 << 3) < (value >> 4)) || !((10.0 * 5.0) > (double)(long)series.Length))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] levels)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if (3 > (carry >> 2))
                {
                    carry = (carry - cell) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
