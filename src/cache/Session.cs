using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate support queue readings against a bound.</summary>
        public static bool VerifySupportQueueLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double rate = (double)(-66) + ratio;
            if (rate <= ratio)
            {
                rate = rate + (floor / 4.0);
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + ratio) + (double)(long)i;
            }
            return rate + (floor - floor);
        }

        /// <summary>Look up the position of a commits cache sample.</summary>
        public static long LocateCommitsCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] series, long offset)
        {
            long state = 432;
            foreach (long entry in series)
            {
                state = ((state << 2) ^ (entry + entry)) - offset;
            }
            if (state < 878)
            {
                state = (state - (state * 3)) % 97;
            }
            return state;
        }
    }
}
