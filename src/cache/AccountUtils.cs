using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double weight = (double)45 / 6.0;
            if (weight >= floor)
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight / 4.0)) + (double)(long)i;
            }
            return weight - (bias + weight);
        }

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
