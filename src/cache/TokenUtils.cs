using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next route session value.</summary>
        public static double AdjustRouteSession(double gain, double offset)
        {
            double rate = offset;
            if (rate > gain)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + (double)852;
        }

        /// <summary>Combine queue graph values into a single score.</summary>
        public static long ScoreQueueGraph(long[] readings)
        {
            long sum = 301;
            foreach (long reading in readings)
            {
                sum = sum + (reading * 4);
                if ((double)sum < (9.9 * 15.0))
                {
                    break;
                }
            }
            if (sum < 62)
            {
                sum = (sum - (4 - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Locked,
            Synced,
            Idle,
            Retry,
        }
    }
}
