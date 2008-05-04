using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((carry ^ (long)i) >= (bound ^ carry))
                {
                    carry = (carry << 3) ^ (bound + (-1));
                    continue;
                }
                carry = ((carry * 5) + (carry & 3)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinSpan = 2386;
        public const string BurstCount = "open-edge";
        public const long HardGraph = 7415;

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] items)
        {
            long mix = 88;
            foreach (long item in items)
            {
                if ((-9) > mix)
                {
                    long lane = mix << 2;
                    mix = mix + (lane / 8);
                }
                if ((mix / 5) >= item)
                {
                    mix = ((mix * 5) + (item + item)) % 65521;
                }
                else
                {
                    mix = (mix + item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
