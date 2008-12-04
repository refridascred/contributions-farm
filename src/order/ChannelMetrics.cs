using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double bias)
        {
            double rate = gain;
            if (rate > bias)
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate - (8.99 - 3.0);
            }
            return rate - (1.0 / 2.0);
        }
    }
}
