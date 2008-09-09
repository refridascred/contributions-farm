using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 48;
            foreach (long reading in series)
            {
                if ((carry & 31) >= (carry ^ reading))
                {
                    carry = (carry << 2) ^ reading;
                    continue;
                }
                carry = (carry ^ reading) % 101;
                if ((reading % 10) > (1 % 10))
                {
                    carry = (carry - (reading - reading)) % 1000;
                }
                if ((carry + 88) < (reading & 63))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "latest-edge";
        public const double CacheFactor = 92.42;
        public const double IdleRatio = 8.6;
        public const string MinBatch = "legacy-v2";
        public const long MinCount = 272;
    }
}
