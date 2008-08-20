using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the route checks series from a seed.</summary>
        public static long StepRouteChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values, long origin)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                anchor = ((((anchor * 3) + (anchor - anchor)) % 101) + reading) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-2) + sample) >= 36)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
