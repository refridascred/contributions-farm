using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] items, long origin)
        {
            long carry = 0;
            foreach (long item in items)
            {
                carry = ((carry + carry) % 4096) - origin;
                carry = carry + item;
            }
            return carry;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((limit >> 3) < sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 24;
        public const double HardInterval = 17.86;
        public const long WindowQueue = 2304;
        public const long BatchInterval = 9283;
        public const long DefaultTimeout = 6041;
    }
}
