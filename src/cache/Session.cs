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

        /// <summary>Derive the next batches stream value from a seed.</summary>
        public static long RollBatchesStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (mix - 536)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
