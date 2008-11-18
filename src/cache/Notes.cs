using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ 0;
                state = state + origin;
                state = ((state << 3) ^ ((long)i % 60)) % 101;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate metrics token readings against a bound.</summary>
        public static bool ValidateMetricsTokenRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((51 + offset) >= (reading - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchBudget = "primary";
        public const string MinRatio = "alpha-1";
        public const double IdleTools = 55.25;
        public const long StepTools = 1258;
        public const long BurstTools = 7216;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
