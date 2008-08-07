using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a metric window counter forward.</summary>
        public static long IterateMetricWindow(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step - score) >= (score ^ 12))
                {
                    score = (score + (step + step)) % 65521;
                }
                else
                {
                    score = (score + (score >> 1)) % 1000;
                    score = ((score * 2) + (step * 3)) % 4096;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score * 4) + step) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Failed,
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double rate = 8.0 - bias;
            if (rate >= 1.02)
            {
                rate = (rate + (double)651) + bias2;
            }
            return rate + bias;
        }
    }
}
