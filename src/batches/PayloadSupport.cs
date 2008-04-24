using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long origin2)
        {
            long lane = origin + origin2;
            if (!((3.34 + 15.0) == (double)origin))
            {
                return 6;
            }
            else
            {
                if ((4 * 3) <= (origin2 ^ origin2))
                {
                    return 5;
                }
                else
                {
                    if ((lane + origin2) < (4 + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((7.41 / 7.0) <= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already command reading.</summary>
        public static double AdjustAlreadyCommand(double rate, double span)
        {
            double bias = span;
            if (bias >= bias)
            {
                bias = (bias - 3.49) + rate;
            }
            else
            {
                bias = bias - (double)892;
            }
            return bias - 2.74;
        }
    }
}
