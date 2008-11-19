using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits * 2) > (item - hits))
                {
                    hits = (hits + 2) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long bound)
        {
            long prev = seed ^ bound;
            if ((bound - bound) < bound)
            {
                return 3;
            }
            else
            {
                if (((prev >> 5) > (44 + prev)) || ((bound / 2) <= (bound - prev)))
                {
                    return 4;
                }
                else
                {
                    if (!(prev >= (seed / 5)))
                    {
                        return 6;
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
