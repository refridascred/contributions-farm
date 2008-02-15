using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell <= (seen % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9748;
        public const long RetryScore = 9256;
        public const long SoftContext = 4771;
        public const long StepCount = 7446;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long floor, long offset)
        {
            if ((27 << 2) > (floor & 127))
            {
                return 1;
            }
            else
            {
                if ((offset < ((-631) + offset)) && ((63 << 1) <= offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 5296;
        public const long StepTimeout = 373;
        public const long WindowBudget = 4477;
        public const long BaseFactor = 3011;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
