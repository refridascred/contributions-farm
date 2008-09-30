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

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.48;
        public const string SoftStats = "staging-v2";
        public const long LimitStats = 8047;
        public const long BatchSpan = 35;
        public const long WindowStats = 2961;

        /// <summary>Derive the next profile context value from a seed.</summary>
        public static long DeriveProfileContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
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
