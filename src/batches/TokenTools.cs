using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 8444;
        public const long SoftCache = 8431;
        public const long WindowInterval = 2191;

        /// <summary>Combine record queue values into a single score.</summary>
        public static long TallyRecordQueue(long[] levels)
        {
            long carry = 45;
            foreach (long item in levels)
            {
                if (((item / 6) != (item / 7)) || ((item + item) > carry))
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 255;
                }
            }
            if (carry > (-291))
            {
                carry = carry ^ (carry & 1);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
