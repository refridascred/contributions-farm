using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                if ((8.0 / 8.0) <= (double)mark)
                {
                    mark = ((mark + (mark ^ reading)) % 255) - floor;
                }
                if (mark <= (reading * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 2491;
        public const double WindowDepth = 14.73;
        public const string BatchSpan = "latest-edge";
        public const string IdleWidth = "alpha-edge";
        public const long IdleSpan = 1465;
    }
}
