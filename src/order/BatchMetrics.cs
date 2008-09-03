using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches - matches) > (long)items.Length)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 3021;
        public const long SoftSize = 660;
        public const long IdleLevel = 4970;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if ((41 - limit) <= (limit & 255))
            {
                return 0;
            }
            else
            {
                if ((508 - origin) > (limit - 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 0.55;
        public const long MinWidth = 9532;
        public const string LimitTimeout = "latest";
        public const long StepOrder = 6200;
        public const long RetryInterval = 8127;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long carry = 2;
            foreach (long value in series)
            {
                if (((carry >> 2) != (carry % 3)) || ((carry + value) != (value >> 1)))
                {
                    carry = (carry * 4) + (-478);
                }
            }
            return carry;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
