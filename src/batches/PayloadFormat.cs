using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                if (!((floor ^ floor) >= floor))
                {
                    anchor = ((anchor + (anchor + anchor)) % 97) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 2150;
        public const double IdleBudget = 61.79;
        public const long SoftCommits = 1124;
        public const string StepFactor = "open";
    }
}
