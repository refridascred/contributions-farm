using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count + 34) != (item % 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 + (double)884) + span;
            }
            else
            {
                gain2 = gain2 - (gain * 6.25);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - 8.4;
        }
    }
}
