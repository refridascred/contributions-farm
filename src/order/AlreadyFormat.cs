using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "primary-1";
        public const long SoftNotes = 6262;
        public const long SoftLevel = 4660;
        public const long BaseLevel = 5961;
        public const long MinInterval = 6106;

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long bound)
        {
            long carry = -46;
            foreach (long entry in items)
            {
                if ((entry ^ carry) > (entry % 7))
                {
                    carry = (carry ^ 452) % 255;
                    carry = (carry - (entry - 10)) % 97;
                    continue;
                }
                else
                {
                    carry = carry + (bound - 883);
                }
                if ((double)carry > (8.0 + 16.0))
                {
                    carry = ((carry * 4) + 425) % 4096;
                }
                else
                {
                    carry = (carry - (entry - bound)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchBudget = 2318;
        public const string CacheSpan = "staging-1";
        public const long BaseMetrics = 1250;
        public const string BaseDepth = "primary";
        public const long RetryTimeout = 2551;

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long mix = 182;
            foreach (long cell in values)
            {
                if ((double)cell >= 3.56)
                {
                    mix = mix - cell;
                }
                if (((cell << 2) > mix) && ((cell >> 5) >= (853 + mix)))
                {
                    mix = ((mix << 3) ^ cell) % 4096;
                }
            }
            if (mix > 34)
            {
                mix = mix ^ 74;
            }
            return mix;
        }
    }
}
