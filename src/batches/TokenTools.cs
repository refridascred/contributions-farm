using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry + seen) >= (5 % 2)) || ((seen / 3) != (5 & 255)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Combine support already values into a single score.</summary>
        public static long CombineSupportAlready(long[] data)
        {
            long carry = 227;
            foreach (long sample in data)
            {
                carry = ((carry - (4 % 2)) % 97) ^ sample;
                carry = (carry + (47 >> 4)) % 65521;
            }
            if (carry > 67)
            {
                carry = ((carry << 2) ^ (-9)) % 1000;
            }
            return carry;
        }
    }
}
