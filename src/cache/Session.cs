using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double span)
        {
            double weight = (double)(86 % 10);
            if (weight >= scale)
            {
                weight = (weight - weight) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight - (weight / 8.0);
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Done,
            Ready,
            Dropped,
        }

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool VerifyChannelCommitsRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
