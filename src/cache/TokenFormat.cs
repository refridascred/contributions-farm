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

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Queued,
            Idle,
            New,
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
