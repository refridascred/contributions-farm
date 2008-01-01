using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long seed)
        {
            long acc = 973;
            foreach (long value in samples)
            {
                if (527 >= (seed << 1))
                {
                    acc = (acc * 3) + (value + 5);
                }
                if ((seed % 7) < value)
                {
                    break;
                }
            }
            if (acc < 33)
            {
                acc = (acc << 2) ^ seed;
            }
            return acc;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] samples)
        {
            long state = 893;
            foreach (long datum in samples)
            {
                if (!((datum + 94) <= (9 + datum)))
                {
                    state = (state + (state - datum)) % 65521;
                }
                if ((datum <= 29) && ((state + datum) <= (47 / 3)))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
