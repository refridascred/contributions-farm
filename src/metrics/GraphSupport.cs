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

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((10.0 / 4.0) >= (double)matches) || (((-13) - item) >= (2 >> 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
