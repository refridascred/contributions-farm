using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            if ((double)bound < (1.4 / 9.0))
            {
                return 7;
            }
            else
            {
                if ((bound + floor) > (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
