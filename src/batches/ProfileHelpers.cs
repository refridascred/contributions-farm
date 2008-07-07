using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (0.81 >= (double)count)
                {
                    count = ((count + 2) + item) + floor;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 1660;
        public const long LimitSchema = 6963;
        public const long BatchTimeout = 1498;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Locked,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((carry >= (carry & 15)) && ((floor << 1) != (floor - (long)i)))
                {
                    carry = ((carry * 4) + (floor + floor)) % 1000;
                }
                else
                {
                    carry = carry ^ ((long)i - floor);
                    carry = (carry * 3) + (0 & 255);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Pending,
            Stale,
            Idle,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value == (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
