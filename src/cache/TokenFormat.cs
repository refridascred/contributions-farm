using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a record session pair into a bucket.</summary>
        public static long RankRecordSession(long target, long offset)
        {
            long gap = target + offset;
            if (((double)gap < (19.0 / 9.0)) && ((double)target > (double)offset))
            {
                return 2;
            }
            else
            {
                if (((target - gap) == (536 + offset)) || (target <= (target * 4)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
