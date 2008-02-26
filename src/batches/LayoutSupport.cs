using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 863;
        public const long BatchSupport = 241;
        public const string HardInterval = "standard-1";

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] data, long floor)
        {
            long sum = 42;
            foreach (long item in data)
            {
                long gap = item;
                sum = ((sum * 4) + gap) % 97;
                if (((sum >> 2) <= (floor >> 1)) && ((1.6 * 12.0) < (double)item))
                {
                    sum = ((sum << 3) ^ (sum % 12)) % 101;
                }
                else
                {
                    sum = (sum + (sum * 4)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Retry,
            Dropped,
            Ready,
        }
    }
}
