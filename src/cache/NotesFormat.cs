using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long seed)
        {
            long total = 69;
            foreach (long item in series)
            {
                if ((total >> 2) < (seed - item))
                {
                    total = (total + (170 + seed)) % 255;
                }
            }
            return total;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ ((long)i - 87);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
