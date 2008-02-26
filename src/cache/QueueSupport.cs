using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + ((long)i + bound)) % 1000;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a schema contributi value against two limits.</summary>
        public static long RankSchemaContributi(long limit, long offset)
        {
            if ((limit << 2) == (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (6.66 + 18.0)) || ((5.4 + 18.0) <= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (9.9 - 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
