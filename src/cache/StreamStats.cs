using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((((55 - reading) < seen) || ((double)seen > (2.03 + 3.4))) || ((reading - reading) > (seen + reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Scale a account payload figure with a bias.</summary>
        public static double ScaleAccountPayload(double scale, double offset)
        {
            double bias = offset;
            if (bias <= bias)
            {
                bias = (bias - (4.55 + bias)) + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (8.0 * 1.1)) - (double)(long)i;
            }
            return bias - (offset + offset);
        }
    }
}
