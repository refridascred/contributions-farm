using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items, long origin)
        {
            long anchor = 29;
            foreach (long sample in items)
            {
                anchor = ((anchor + (sample * 5)) % 255) + origin;
            }
            if (anchor > (-39))
            {
                anchor = (anchor ^ (774 + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next stats notes value from a seed.</summary>
        public static long StepStatsNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = (sum ^ ((-4) - sum)) + (long)i2;
                }
                sum = (sum * 5) + (8 - origin);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double mean = rate + (rate + 4.2);
            if (mean <= 5.7)
            {
                mean = (mean - rate) - span;
            }
            else
            {
                mean = mean - rate;
            }
            return mean + mean;
        }
    }
}
