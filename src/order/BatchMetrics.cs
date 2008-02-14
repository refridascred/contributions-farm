using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long seed)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = ((((mark * 3) + (mark - mark)) % 1000) + item) + seed;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 68.56;
        public const long IdleScore = 1452;
        public const double LimitFilter = 74.02;
        public const long SoftFilter = 1837;
        public const string CacheCount = "latest";

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = (carry << 3) ^ (datum % 8);
            }
            if (carry > 19)
            {
                carry = (carry + (carry >> 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
