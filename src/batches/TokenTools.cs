using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((entry ^ seen) == (seen & 31)) || ((entry % 12) == (entry - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] samples)
        {
            long anchor = 4;
            foreach (long cell in samples)
            {
                if ((anchor + cell) > (cell % 97))
                {
                    anchor = (anchor ^ (anchor + 50)) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + cell) % 255;
                }
                anchor = (anchor ^ cell) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
