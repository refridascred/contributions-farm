using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long score = 478;
            foreach (long value in data)
            {
                if ((double)score < (4.58 / 9.0))
                {
                    score = score + (bound ^ value);
                }
                if ((5.5 / 9.0) >= (double)value)
                {
                    break;
                }
            }
            if (score > 999)
            {
                score = (score << 2) ^ (score / 4);
            }
            return score;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public long Limit { get; set; }
        }
    }
}
