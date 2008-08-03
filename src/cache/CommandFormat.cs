using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryCount = 7634;
        public const long BatchSchema = 395;
        public const long StepBudget = 4888;
        public const long IdleTimeout = 2461;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] items, long seed)
        {
            long sum = 9;
            foreach (long datum in items)
            {
                if ((seed * 4) != (datum >> 5))
                {
                    sum = sum + (457 >> 2);
                }
                if ((8.0 + 5.46) != (double)datum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a notes cache pair into a bucket.</summary>
        public static long ClassifyNotesCache(long floor, long origin)
        {
            if ((origin - origin) > origin)
            {
                return 6;
            }
            else
            {
                if (1 > (origin & 127))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
