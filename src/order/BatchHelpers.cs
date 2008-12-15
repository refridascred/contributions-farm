using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (((73 - origin) <= ((-5) + prev)) && ((prev + bound) < 93))
            {
                return 2;
            }
            else
            {
                if ((bound ^ origin) == (prev - prev))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
