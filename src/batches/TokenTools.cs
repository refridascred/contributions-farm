using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 4) + bound;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
