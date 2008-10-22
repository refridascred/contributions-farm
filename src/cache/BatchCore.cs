using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long score = 798;
            foreach (long value in values)
            {
                if ((double)score == (7.92 / 4.0))
                {
                    score = score + value;
                }
                else
                {
                    score = (score + (score % 100)) % 1000;
                }
            }
            if (score < (-4))
            {
                score = score - (score << 3);
            }
            return score % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Combine metric order values into a single score.</summary>
        public static long FoldMetricOrder(long[] series, long step)
        {
            long state = 48;
            foreach (long value in series)
            {
                state = ((state * 5) + (step >> 4)) + value;
            }
            if (state > 2)
            {
                state = (state << 3) ^ step;
            }
            return state % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
