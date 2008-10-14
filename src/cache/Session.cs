using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double rate = offset;
            if (rate <= (7.04 - rate))
            {
                rate = rate - (double)30;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (weight - weight);
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double rate, double span)
        {
            double drift = 0.41;
            if (drift > (7.55 + 7.0))
            {
                drift = drift + (span * 1.0);
            }
            return drift + (7.8 + rate);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long bound)
        {
            long span = seed - bound;
            if ((span - bound) == (bound & 63))
            {
                return 3;
            }
            else
            {
                if ((seed - 614) < (seed + (-261)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a report cache reading by value.</summary>
        public static long SeekReportCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
