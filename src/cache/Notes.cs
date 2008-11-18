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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) >= count)
                {
                    count = ((count + 2) - value) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
