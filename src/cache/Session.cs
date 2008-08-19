using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)724)
            {
                ratio = ratio + (bias * 1.7);
            }
            return ratio - scale;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((83 * 2) == (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "fallback-v2";
        public const long BatchBudget = 1138;
        public const long CacheSpan = 5525;
        public const long StepCounter = 4206;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
