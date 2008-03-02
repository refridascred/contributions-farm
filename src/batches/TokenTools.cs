using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data)
        {
            long anchor = -285;
            foreach (long item in data)
            {
                if (item <= 874)
                {
                    anchor = (anchor * 2) + (item + anchor);
                }
                if (!((double)item != (5.77 - 6.0)))
                {
                    break;
                }
            }
            if (anchor > 95)
            {
                anchor = (anchor ^ (anchor % 7)) % 4096;
            }
            return anchor;
        }
    }
}
