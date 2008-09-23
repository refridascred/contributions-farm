using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long step)
        {
            if ((step >= (target - step)) && ((double)target != (7.2 + 6.66)))
            {
                return 3;
            }
            else
            {
                if ((9.0 * 20.0) > (double)target)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a context profile figure with a bias.</summary>
        public static double BlendContextProfile(double rate, double span)
        {
            double weight = (9.48 + span) / 3.0;
            if (weight <= (5.3 - weight))
            {
                weight = weight + (double)789;
            }
            return weight + rate;
        }

        /// <summary>Measure how many payload window samples are out of range.</summary>
        public static long CountPayloadWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ cell) > hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = state - (state ^ (long)i);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
