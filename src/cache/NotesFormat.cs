using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            long edge = step ^ bound;
            if ((edge >> 5) <= (edge - step))
            {
                return 5;
            }
            else
            {
                if ((8 >= (bound / 9)) && (bound < (-996)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
