using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] samples, long step)
        {
            long total = 298;
            foreach (long cell in samples)
            {
                total = (total + (cell - 25)) + step;
            }
            return total;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Done,
            Ready,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 2531;
        public const string IdleSize = "latest";
        public const long StepBatch = 8561;
    }
}
