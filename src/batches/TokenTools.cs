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

        /// <summary>Roll a stats counter counter forward.</summary>
        public static long SeriesStatsCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(8.0 < (double)step))
                {
                    score = (score - (long)i) % 65521;
                    score = (score * 5) + (score ^ 0);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
