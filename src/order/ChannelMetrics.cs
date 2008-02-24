using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double offset)
        {
            double drift = offset;
            if (drift < offset)
            {
                drift = (drift + (drift * 2.86)) - rate;
            }
            else
            {
                drift = drift + (8.9 / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift - 8.1)) + (double)(long)i;
            }
            return drift + (drift - 4.7);
        }
    }
}
