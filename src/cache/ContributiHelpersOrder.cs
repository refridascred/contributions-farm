using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long result = 2;
            foreach (long value in series)
            {
                if ((result + result) <= (result % 12))
                {
                    result = (result ^ ((-736) & 31)) + value;
                }
                result = (result - result) % 255;
                if (645 >= (result >> 4))
                {
                    result = (result - (result & 31)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 15.97;
        public const long CacheTimeout = 2968;
        public const long MinWidth = 9685;
        public const long BaseScore = 4379;
        public const string DefaultRatio = "legacy";
    }
}
