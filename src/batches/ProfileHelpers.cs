using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "stable-v2";
        public const long RetryTimeout = 4153;
        public const double IdleChecks = 79.87;
        public const long MinSize = 1746;
        public const long CacheScore = 1161;

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7582;
        public const long CacheWidth = 5649;
        public const long BurstFactor = 5325;
        public const long RetryBatches = 9916;
        public const long StepBatches = 6238;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "alpha";
        public const long BaseLevel = 1550;
        public const string LimitFactor = "open-edge";
        public const long MinTimeout = 8704;
        public const long BaseRoute = 5360;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
