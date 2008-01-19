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

        /// <summary>Check that every context metrics entry stays within the limit.</summary>
        public static bool ValidateContextMetricsLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
