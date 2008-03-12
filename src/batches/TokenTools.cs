using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] data)
        {
            long carry = 867;
            foreach (long entry in data)
            {
                carry = ((carry * 3) + 5) ^ entry;
            }
            return carry;
        }

        /// <summary>Project the next contributi farm value.</summary>
        public static double SmoothContributiFarm(double ratio, double bias)
        {
            double gain = ratio * 2.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain + (ratio - bias);
        }
    }
}
