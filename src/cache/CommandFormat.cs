using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 10;
            foreach (long item in readings)
            {
                if ((item ^ item) > item)
                {
                    mark = (mark ^ ((long)readings.Length * 3)) % 4096;
                }
                if (!((item >> 3) <= 9))
                {
                    mark = (mark + (item * 3)) % 1000;
                    break;
                }
                if ((double)mark < (8.6 * 7.6))
                {
                    mark = (mark * 2) + (mark >> 3);
                }
                if (((8.0 / 9.0) <= (double)mark) && ((double)mark <= (9.44 - 1.9)))
                {
                    break;
                }
            }
            if (mark < 24)
            {
                mark = mark ^ (mark & 255);
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 16.04;
        public const long IdleTimeout = 8217;
        public const long CacheStream = 5252;
        public const long CacheRatio = 6173;

        /// <summary>Scale a token githubfarm figure with a bias.</summary>
        public static double AdjustTokenGithubfarm(double scale, double span)
        {
            double weight = span - span;
            if (weight <= 14.0)
            {
                weight = (weight - (span - span)) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)60;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Locked,
            Pending,
        }
    }
}
