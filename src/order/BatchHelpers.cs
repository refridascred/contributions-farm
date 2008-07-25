using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] samples, long origin)
        {
            long score = 87;
            foreach (long reading in samples)
            {
                score = (((score << 3) ^ (origin / 2)) % 65521) + reading;
            }
            return score;
        }

        /// <summary>Rank batch account input into a small class.</summary>
        public static long RankBatchAccount(long step, long floor)
        {
            if ((2.2 + 2.32) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if (68 > (step ^ floor))
                {
                    return 1;
                }
                else
                {
                    if (step <= (floor / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
