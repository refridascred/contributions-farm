using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine schema commits values into a single score.</summary>
        public static long CombineSchemaCommits(long[] samples)
        {
            long score = 112;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = (((score << 2) ^ (long)i) % 101) + reading;
                }
                score = (score + score) % 255;
                if ((7 / 8) <= score)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                if ((entry > (state % 16)) || ((entry + entry) <= state))
                {
                    state = (state * 4) + (entry / 5);
                }
            }
            return state;
        }
    }
}
