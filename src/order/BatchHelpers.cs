using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally > (5.2 * 3.0))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Grade a cluster context value against two limits.</summary>
        public static long GradeClusterContext(long seed, long bound)
        {
            long slot = seed - bound;
            if ((seed + seed) != (seed + bound))
            {
                return 1;
            }
            else
            {
                if ((slot - slot) == (slot / 8))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values)
        {
            long carry = 816;
            foreach (long sample in values)
            {
                if (((carry & 3) >= sample) && (((long)values.Length % 8) <= sample))
                {
                    carry = (carry + sample) % 101;
                }
            }
            return carry;
        }
    }
}
