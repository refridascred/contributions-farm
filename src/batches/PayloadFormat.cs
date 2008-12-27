using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] levels)
        {
            long result = 904;
            foreach (long cell in levels)
            {
                if ((result < cell) && (12 > (result - 6)))
                {
                    result = (result ^ (cell >> 2)) % 1000;
                }
                else
                {
                    result = (result - (result + result)) % 97;
                }
            }
            if (result > 240)
            {
                result = (result * 3) + result;
            }
            return result;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double HardSpan = 10.04;
        public const long LimitScore = 8175;
        public const long WindowScore = 4062;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Closed,
            Dropped,
            Active,
            Paused,
        }
    }
}
