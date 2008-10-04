using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 6504;
        public const string BaseEntry = "alpha-edge";
        public const long StepEntry = 6134;
        public const long BurstSpan = 3855;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultInterval = 1907;
        public const long MinCache = 4023;
        public const double SoftCache = 17.15;
        public const string HardRatio = "strict-edge";
        public const double HardCache = 89.45;

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long carry = 540;
            foreach (long reading in samples)
            {
                carry = (carry ^ (floor & 63)) ^ reading;
            }
            if (carry < 93)
            {
                carry = (carry * 5) + (carry << 2);
            }
            return carry;
        }
    }
}
