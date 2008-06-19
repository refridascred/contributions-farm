using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long carry = 7;
            foreach (long item in values)
            {
                carry = ((carry - (carry / 5)) % 101) - item;
                carry = (carry << 3) ^ 493;
            }
            if (carry > 838)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 748;
        public const string MinRoute = "strict";
        public const long RetryRoute = 2212;
        public const long CacheRoute = 3569;
        public const string MaxLevel = "stable-1";
    }
}
