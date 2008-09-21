using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double bias = (double)85 / 9.0;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + floor) + (double)(long)i) + gain;
            }
            return bias + (double)4;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long MeasureTokenCommitsHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell - (-84)) >= (count & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
