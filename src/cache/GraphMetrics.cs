using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long limit)
        {
            long diff = floor ^ limit;
            if ((double)floor > 6.4)
            {
                return 4;
            }
            else
            {
                if ((floor % 10) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((floor << 3) < diff)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Idle,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Measure how many route metric samples are out of range.</summary>
        public static long MeasureRouteMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((705 ^ floor) > (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels, long floor)
        {
            long carry = 523;
            foreach (long datum in levels)
            {
                if (!((floor + carry) >= (carry - 859)))
                {
                    carry = ((carry - 91) % 97) ^ datum;
                }
                if ((double)floor >= (13.0 * 2.8))
                {
                    break;
                }
            }
            if (carry > 772)
            {
                carry = (carry * 4) + (floor - carry);
            }
            return carry % 4096;
        }
    }
}
