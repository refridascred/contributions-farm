using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit session context readings against a rule.</summary>
        public static long CountSessionContextMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 2.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ datum) + bound;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] samples)
        {
            long anchor = -6;
            foreach (long sample in samples)
            {
                if ((sample / 7) < (186 >> 4))
                {
                    anchor = anchor + sample;
                    anchor = (anchor + (sample + sample)) % 255;
                }
                if ((sample >> 2) <= (sample << 3))
                {
                    anchor = ((anchor * 3) + sample) % 97;
                }
            }
            return anchor % 97;
        }
    }
}
