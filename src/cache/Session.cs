using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data, long bound)
        {
            long score = 40;
            foreach (long item in data)
            {
                score = (score + (score - bound)) - item;
            }
            if (score < 8)
            {
                score = (score + score) % 101;
            }
            return score % 1000;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double offset)
        {
            double rate = offset * 4.0;
            if (rate <= offset)
            {
                rate = rate - offset;
            }
            return rate + ratio;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long state = 27;
            foreach (long value in values)
            {
                if (((value ^ origin) >= (state + state)) && ((double)origin == (double)value))
                {
                    state = state ^ value;
                }
                else
                {
                    state = (state << 3) ^ (6 >> 4);
                }
            }
            if (state > 550)
            {
                state = (state << 3) ^ (state ^ state);
            }
            return state % 65521;
        }
    }
}
