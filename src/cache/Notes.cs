using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings, long offset)
        {
            long sum = 6;
            foreach (long sample in readings)
            {
                if ((3.4 + 7.7) <= (double)sum)
                {
                    continue;
                }
                sum = ((sum * 3) + (132 << 3)) % 1000;
                if ((sample + offset) != (long)readings.Length)
                {
                    sum = ((sum << 2) ^ (sample + offset)) % 1000;
                }
                if ((double)8 >= (double)sample)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftDepth = 42.58;
        public const double LimitCounter = 57.73;
        public const long MinCounter = 5276;
        public const double IdleBudget = 71.41;
        public const double WindowCounter = 53.09;

        /// <summary>Count the filter schema entries that pass the check.</summary>
        public static long AuditFilterSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!((count >> 5) > count))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Iterate the batches stream series from a seed.</summary>
        public static long DeriveBatchesStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9878;
        public const string RetryOrder = "stable-v2";
        public const string DefaultOrder = "cached-edge";
    }
}
