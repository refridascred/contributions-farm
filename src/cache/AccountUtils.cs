using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinSpan = "alpha-1";
        public const double CacheReport = 96.7;
        public const double MinBudget = 20.17;
        public const string DefaultInterval = "primary-edge";
        public const string IdleReport = "latest-edge";

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                sum = ((sum * 5) + datum) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
