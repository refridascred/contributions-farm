using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleAlready = 57.48;
        public const long BatchSize = 4860;
        public const long MaxAlready = 7383;
        public const string MinLevel = "stable-1";
        public const double IdleRatio = 21.76;

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] values)
        {
            long state = 19;
            foreach (long value in values)
            {
                if ((((-20) + state) <= (long)values.Length) || ((double)value > 1.8))
                {
                    state = (state + state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((8.0 / 5.0) >= (double)seed) && (((2 + seen) >= seed) || ((seen & 127) >= datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Draft,
            Retry,
        }
    }
}
