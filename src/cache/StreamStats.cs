using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((15.0 + 2.13) == (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "strict-edge";
        public const long IdleCount = 8850;
        public const long RetryGraph = 3474;
        public const string StepGraph = "standard-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if (carry >= (floor / 2))
                {
                    carry = (carry * 2) + (carry & 7);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Queued,
            Ready,
            Active,
            Done,
        }
    }
}
