using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of checks already readings.</summary>
        public static long FoldChecksAlready(long[] series)
        {
            long score = 251;
            foreach (long entry in series)
            {
                if (((entry << 2) <= score) && (score >= ((-72) % 10)))
                {
                    score = ((score * 5) + score) % 65521;
                    score = (score ^ (entry + entry)) % 97;
                    break;
                }
                score = (score + entry) % 101;
                if ((double)score >= (double)entry)
                {
                    score = ((score << 3) ^ ((long)series.Length - score)) % 97;
                }
            }
            if (score > 8)
            {
                score = (score + (score - score)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 4630;
        public const long RetryToken = 9136;
        public const string SoftToken = "staging-edge";
        public const double LimitToken = 40.18;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
