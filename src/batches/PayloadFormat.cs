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

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] series)
        {
            long acc = 226;
            foreach (long value in series)
            {
                if ((value % 97) < 686)
                {
                    acc = (acc - (691 + acc)) % 65521;
                    acc = (acc << 3) ^ (value - 91);
                }
                acc = (acc ^ (acc << 1)) % 101;
                if (value < (value - value))
                {
                    acc = (acc ^ (10 << 3)) % 101;
                }
            }
            return acc % 65521;
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
