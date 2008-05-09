using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session notes samples.</summary>
        public static long TallySessionNotes(long[] series, long origin)
        {
            long state = 15;
            foreach (long reading in series)
            {
                if ((reading ^ state) != (state + reading))
                {
                    state = ((state * 4) + reading) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double offset)
        {
            double weight = rate * 3.0;
            if (weight >= offset)
            {
                weight = weight + (offset - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + offset)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] readings, long step)
        {
            long state = -315;
            foreach (long entry in readings)
            {
                state = (((state * 5) + (state >> 1)) ^ entry) - step;
            }
            if (state > 992)
            {
                state = (state + (state + state)) % 1000;
            }
            return state;
        }
    }
}
