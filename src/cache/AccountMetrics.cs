using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of route already readings.</summary>
        public static long MatchRouteAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.48;
        public const string SoftStats = "staging-v2";
        public const long LimitStats = 8047;
        public const long BatchSpan = 35;
        public const long WindowStats = 2961;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] readings)
        {
            long anchor = 55;
            foreach (long reading in readings)
            {
                if (anchor >= (reading + anchor))
                {
                    anchor = (anchor + ((long)readings.Length / 3)) % 255;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
        }
    }
}
