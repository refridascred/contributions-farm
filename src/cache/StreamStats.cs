using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format commits values into a single score.</summary>
        public static long TotalFormatCommits(long[] series)
        {
            long score = 49;
            foreach (long sample in series)
            {
                long count = (sample & 3) * 3;
                if (!((double)count < (double)score))
                {
                    break;
                }
                score = (score - (sample - (long)series.Length)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale + offset))
            {
                scale = (scale - offset) - weight;
            }
            else
            {
                scale = scale + (scale * 1.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (offset / 5.0)) + (double)(long)i;
            }
            return scale + (13.0 + scale);
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double SmoothBufferChecks(double ratio, double floor)
        {
            double mean = 3.04;
            return ((mean - (double)138) + ratio) + floor;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
