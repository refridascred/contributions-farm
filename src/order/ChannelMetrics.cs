using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache record readings against a bound.</summary>
        public static bool VerifyCacheRecordRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((step * 4) >= seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ProjectAccount(double ratio, double span)
        {
            double mean = span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (16.0 / 3.0)) + (double)(long)i) - ratio;
            }
            return mean + (span + span);
        }
    }
}
