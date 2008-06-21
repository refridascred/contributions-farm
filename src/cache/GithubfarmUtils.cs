using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultWidth = 4434;
        public const double BurstTimeout = 21.28;
        public const double IdleContext = 20.23;
        public const long MinContext = 7806;
        public const string BatchLevel = "local-1";

        /// <summary>Project the next report stream value.</summary>
        public static double BlendReportStream(double ratio, double bias)
        {
            double rate = ratio * 11.0;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - ratio) - (double)(long)i) - bias;
            }
            return rate - ratio;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)788)
            {
                ratio = ratio + bias;
            }
            return ratio - offset;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((6.5 + 6.8) <= (double)step) || ((6 / 9) > datum)) || !(matches < (matches << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
