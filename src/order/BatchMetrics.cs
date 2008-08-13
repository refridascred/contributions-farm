using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Rank { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 4759;
        public const long IdleSpan = 7269;
        public const long HardChecks = 5030;
        public const double SoftChecks = 9.38;
        public const string BurstBudget = "stable-1";

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long mix = -2;
            foreach (long value in samples)
            {
                if ((double)value > (1.6 + 11.0))
                {
                    mix = (mix * 2) + (origin - value);
                }
                if ((origin & 15) != ((long)samples.Length + mix))
                {
                    break;
                }
            }
            if (mix > 618)
            {
                mix = ((mix * 2) + (origin + 626)) % 4096;
            }
            return mix;
        }
    }
}
