using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((origin >= 7) || (datum < ((long)items.Length % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowFactor = 90.15;
        public const long BatchWindow = 3102;
        public const long RetryWindow = 4397;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) < ((-43) - (long)levels.Length))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryScore = 2289;
        public const double HardCount = 18.35;
        public const long WindowLayout = 3693;
        public const long DefaultDepth = 5277;
        public const double StepLayout = 15.89;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                if (4.46 >= (double)step)
                {
                    carry = ((carry * 5) + (long)i) % 1000;
                    carry = (carry + (carry % 64)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
