using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum - (sum << 1)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
