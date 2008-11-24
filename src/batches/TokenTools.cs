using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell & 127) < 31)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] levels, long seed)
        {
            long anchor = 796;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor * 3) + (seed - datum)) ^ (long)i;
                }
                anchor = (anchor - datum) % 97;
                if (seed > (27 << 1))
                {
                    break;
                }
            }
            if (anchor < (-9))
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }
    }
}
