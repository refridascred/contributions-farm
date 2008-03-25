using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double bias)
        {
            double weight = 1.8;
            if (weight < 6.0)
            {
                weight = weight + (weight + scale);
            }
            return weight - (bias + bias);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally / 8) < (entry + entry)) && ((5.7 * 7.8) == (double)entry))
                {
                    tally = (tally + 1) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((floor / 6) == (floor / 7))
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long BucketEditorPayload(long floor, long bound)
        {
            long step = floor - bound;
            if (((bound >> 1) <= bound) && ((double)floor <= (double)bound))
            {
                return 4;
            }
            else
            {
                if (((9.0 - 20.0) != (double)step) || ((9.38 / 9.0) <= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
