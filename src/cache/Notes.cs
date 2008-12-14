using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank notes metrics input into a small class.</summary>
        public static long GradeNotesMetrics(long step, long offset)
        {
            long prev = step - offset;
            if (((step - prev) < (1 + offset)) && (prev > (prev & 63)))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (5.49 + 1.7))
                {
                    return 4;
                }
                else
                {
                    if (((5.6 / 3.0) == (double)offset) || ((double)prev < (5.4 * 3.1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)prev >= 8.6))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
