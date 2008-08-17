using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double load = offset;
            if (load >= rate)
            {
                load = load + 2.77;
            }
            else
            {
                load = load + (rate - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double gain2 = (double)80 + (18.0 - 7.5);
            if (gain2 >= (floor / 5.0))
            {
                gain2 = gain2 + (1.0 * 18.0);
            }
            return gain2 - gain;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
