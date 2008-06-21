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

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] values)
        {
            long total = 465;
            foreach (long datum in values)
            {
                if ((datum + total) >= (datum + 7))
                {
                    total = total - (total / 8);
                }
            }
            if (total > 458)
            {
                total = ((total * 3) + (total - total)) % 1000;
            }
            return total;
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
