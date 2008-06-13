using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double bias)
        {
            double drift = 8.3;
            if (drift >= rate)
            {
                drift = (drift + drift) + bias;
            }
            else
            {
                drift = drift - (double)10;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 0.5) + (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if (((bound + bound2) > (bound / 9)) && ((bound + bound) != ((-19) + bound)))
            {
                return 3;
            }
            else
            {
                if ((7.88 / 9.0) < (double)bound)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] readings)
        {
            long state = 14;
            foreach (long item in readings)
            {
                if ((double)(-888) >= (double)item)
                {
                    state = ((state * 4) + (state >> 3)) % 65521;
                }
                else
                {
                    state = state + (391 >> 5);
                }
            }
            return state;
        }
    }
}
