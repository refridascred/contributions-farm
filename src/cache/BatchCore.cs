using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double bias)
        {
            double bias2 = (double)(41 + 460);
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias + gain)) + (double)(long)i;
            }
            return bias2 + 6.0;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double scale, double bias)
        {
            double gain = scale;
            return gain + (bias / 5.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (step > (step & 15))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series, long limit)
        {
            long carry = 714;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (9 + (long)series.Length)) % 65521;
                carry = ((carry * 2) + reading) % 4096;
                if (reading <= limit)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
