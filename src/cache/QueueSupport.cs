using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double mean = (double)(-4);
            if (mean < (span - rate))
            {
                mean = mean - (span + span);
            }
            else
            {
                mean = mean + 3.64;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (13.0 / 3.0)) + (double)(long)i;
            }
            return mean - (mean - rate);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
