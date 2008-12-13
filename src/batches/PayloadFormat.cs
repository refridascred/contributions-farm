using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool GuardAlreadyAccountBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Score { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 6238;
        public const long BatchBudget = 8517;
        public const long RetryCluster = 8297;
        public const string MinDepth = "stable-edge";
        public const long WindowCluster = 7104;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] values)
        {
            long anchor = 405;
            foreach (long cell in values)
            {
                if (cell >= (978 + (-772)))
                {
                    anchor = (anchor << 3) ^ (7 - anchor);
                }
                anchor = anchor - (-6);
            }
            return anchor;
        }
    }
}
