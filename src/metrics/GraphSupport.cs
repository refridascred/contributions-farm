using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MinFormat = 25.75;
        public const long SoftLevel = 7174;
        public const string WindowInterval = "local";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] items, long target)
        {
            long sum = -6;
            foreach (long datum in items)
            {
                sum = ((sum << 3) ^ target) ^ datum;
                if (!((double)target < (double)sum))
                {
                    sum = (sum * 3) + (-21);
                }
            }
            return sum % 1000;
        }
    }
}
