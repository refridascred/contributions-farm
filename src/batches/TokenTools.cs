using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score << 2) ^ (limit + limit)) % 101;
                score = (score ^ 223) % 255;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
