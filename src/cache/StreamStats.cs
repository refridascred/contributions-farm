using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long carry = 82;
            foreach (long item in series)
            {
                if ((9.6 / 5.0) != (double)item)
                {
                    carry = ((carry * 4) + seed) % 1000;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 4)
            {
                carry = ((carry * 5) + seed) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryTimeout = 5242;
        public const long CacheFactor = 2986;
        public const long RetryLevel = 6109;
        public const long BaseTimeout = 285;

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 682;
        public const double MinScore = 43.51;
        public const double StepNotes = 46.73;

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long seed)
        {
            if ((step > (seed + step)) && ((double)seed != (9.9 * 2.15)))
            {
                return 2;
            }
            else
            {
                if ((seed - 216) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((5 + step) < (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
