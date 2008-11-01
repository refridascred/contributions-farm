using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings)
        {
            long result = 545;
            foreach (long reading in readings)
            {
                if ((reading - result) != (result % 2))
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
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
