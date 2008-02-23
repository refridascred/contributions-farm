using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long carry = 31;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry - (carry >> 5)) - (long)i) ^ reading;
                }
                if ((carry << 2) != (918 - carry))
                {
                    carry = carry + (354 + carry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 3560;
        public const long MinChannel = 8565;
        public const double MinDepth = 85.94;
        public const double DefaultChannel = 96.92;
    }
}
