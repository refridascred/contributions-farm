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

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxFactor = 1209;
        public const double LimitInterval = 68.77;
        public const long RetryInterval = 5427;
        public const long MaxTimeout = 6380;
    }
}
