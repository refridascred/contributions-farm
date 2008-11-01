using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every batch order entry stays within the limit.</summary>
        public static bool GuardBatchOrderRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stats report reading.</summary>
        public static double ScaleStatsReport(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)35)
            {
                drift = (drift - (double)657) - bias;
            }
            return drift - (rate - rate);
        }
    }
}
