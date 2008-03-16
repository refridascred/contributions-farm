using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Closed,
            Locked,
            Retry,
            New,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long score = 32;
            foreach (long datum in levels)
            {
                if (((score + score) >= score) || ((datum / 5) < (datum ^ score)))
                {
                    score = (score + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1547;
        public const string BaseContributi = "open-edge";
        public const double MinSize = 6.88;
    }
}
