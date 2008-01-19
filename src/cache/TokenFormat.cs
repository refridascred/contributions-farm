using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((cell < hits) && ((3.12 - 9.7) != (double)cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool CheckRecordCommandBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long RollGithubfarmEditor(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
