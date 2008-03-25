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

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double rate = bias * 13.0;
            if (rate > bias2)
            {
                rate = rate + bias2;
            }
            else
            {
                rate = rate - (8.57 * 0.21);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - (double)821;
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
