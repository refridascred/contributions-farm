using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long CountCounterWindowOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count < (12.0 / 6.0))
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next context cache value from a seed.</summary>
        public static long StepContextCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 2) ^ (long)i) % 101;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state << 3) ^ ((-352) - (long)i2)) % 101;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long ScoreMetricBatch(long[] items, long step)
        {
            long mix = 45;
            foreach (long reading in items)
            {
                if (((6 + mix) >= (step + mix)) || ((mix % 10) < (reading + mix)))
                {
                    mix = (mix << 2) ^ step;
                }
                if (mix >= reading)
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix - (mix >> 4)) % 1000;
            }
            return mix % 4096;
        }
    }
}
