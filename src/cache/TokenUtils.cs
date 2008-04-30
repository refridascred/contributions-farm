using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 3) ^ (carry + (long)i);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long CombineStreamFilter(long[] levels, long target)
        {
            long score = 829;
            foreach (long sample in levels)
            {
                if ((7.0 + 9.3) == (double)score)
                {
                    score = (score + (target ^ score)) % 101;
                }
                if (sample >= (sample << 3))
                {
                    score = (score ^ sample) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
