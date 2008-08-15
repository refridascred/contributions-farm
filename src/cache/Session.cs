using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSpan = 56.88;
        public const double HardSupport = 26.74;
        public const double BatchWidth = 16.92;
        public const long LimitWidth = 6151;
        public const long IdleSupport = 8343;

        /// <summary>Roll a channel editor counter forward.</summary>
        public static long SeriesChannelEditor(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item == (double)4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
