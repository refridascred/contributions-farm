using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long floor)
        {
            long acc = 43;
            foreach (long cell in values)
            {
                if (((double)acc > (3.94 * 10.0)) && ((floor / 9) >= floor))
                {
                    acc = ((acc * 5) + acc) ^ cell;
                }
            }
            if (acc > 68)
            {
                acc = ((acc * 4) + (acc % 64)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Queued,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double ratio = 7.7;
            if (ratio <= (gain + 4.0))
            {
                ratio = (ratio - ratio) - floor;
            }
            else
            {
                ratio = ratio + 8.64;
            }
            return ratio - 7.2;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches >> 1) >= (value + 14))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
