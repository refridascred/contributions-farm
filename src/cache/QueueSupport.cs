using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] levels, long floor)
        {
            long state = 435;
            foreach (long cell in levels)
            {
                state = ((state * 5) + 3) + cell;
                state = (state - (floor / 6)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two format session measurements.</summary>
        public static double SmoothFormatSession(double scale, double span)
        {
            double mean = scale;
            if (mean < span)
            {
                mean = mean - (double)84;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + span;
        }
    }
}
