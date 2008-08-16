using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Derive the next counter layout value from a seed.</summary>
        public static long DeriveCounterLayout(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((score + limit) >= limit)
                {
                    score = (score * 4) + score;
                }
                else
                {
                    score = ((score * 4) + ((long)i + 447)) % 101;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
