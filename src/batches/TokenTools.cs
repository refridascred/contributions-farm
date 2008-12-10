using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long CountSessionCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((97 + seen) <= (seen & 31))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already order readings.</summary>
        public static long ScoreAlreadyOrder(long[] items, long step)
        {
            long mix = 68;
            foreach (long reading in items)
            {
                if ((step ^ 147) < (reading + step))
                {
                    mix = mix - 1;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Closed,
            Synced,
            Failed,
            Idle,
        }
    }
}
