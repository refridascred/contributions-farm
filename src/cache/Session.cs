using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 715;
        public const long StepQueue = 7312;
        public const long BaseQueue = 5981;

        /// <summary>Combine order cluster values into a single score.</summary>
        public static long ScoreOrderCluster(long[] series)
        {
            long sum = -851;
            foreach (long entry in series)
            {
                sum = (sum ^ (entry + entry)) % 97;
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long score = 57;
            foreach (long entry in series)
            {
                if ((score > (score % 12)) || ((double)score < (13.0 / 5.0)))
                {
                    score = ((score - (score >> 5)) % 1000) ^ entry;
                }
                else
                {
                    score = (score ^ (score * 3)) % 65521;
                }
                if ((9 * 3) >= (score << 1))
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            if (score < (-596))
            {
                score = (score + score) % 255;
            }
            return score;
        }

        /// <summary>Audit buffer schema readings against a rule.</summary>
        public static long CountBufferSchemaHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((444 + datum) > (seed + tally)) && (5.0 < (double)datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
