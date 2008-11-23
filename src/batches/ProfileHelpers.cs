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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry % 2) != (entry >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long floor, long origin)
        {
            if ((floor + origin) == (501 >> 4))
            {
                return 3;
            }
            else
            {
                if (((floor >> 2) > (origin * 2)) && (origin >= 92))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

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
