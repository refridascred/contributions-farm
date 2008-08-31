using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "alpha-v2";
        public const string HardFactor = "local-edge";
        public const long WindowSupport = 3738;
        public const string CacheSupport = "open-v2";
        public const string MaxSupport = "stable-edge";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Combine support checks values into a single score.</summary>
        public static long DigestSupportChecks(long[] readings)
        {
            long state = 58;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ cell) % 4096;
                if (state < (cell + state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long anchor = 382;
            foreach (long value in levels)
            {
                if ((value < offset) && ((831 * 5) <= (value * 4)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
                if ((value >> 2) >= offset)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (double)tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
