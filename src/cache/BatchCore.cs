using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double bias, double bias2)
        {
            double weight = (double)(-1) * 2.0;
            if (weight >= bias)
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight - (1.81 + bias2);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (0.4 * 14.0)) + (double)(long)i;
            }
            return weight + (bias2 * 7.9);
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double rate, double span)
        {
            double ratio = span * 4.99;
            if (ratio > rate)
            {
                ratio = ratio + (double)0;
            }
            else
            {
                ratio = ratio + (span * 0.6);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double mean = (double)(1 - 645);
            if (mean > scale)
            {
                mean = (mean - mean) + floor;
            }
            else
            {
                mean = mean + (double)22;
            }
            return mean + scale;
        }
    }
}
