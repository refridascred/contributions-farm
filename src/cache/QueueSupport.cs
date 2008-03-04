using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the githubfarm commits entries that pass the check.</summary>
        public static long AuditGithubfarmCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((6 % 24) == (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ (datum * 5)) % 65521;
                if ((datum * 3) <= (datum % 60))
                {
                    score = score - (32 + score);
                    score = (score * 3) + (score * 4);
                }
                else
                {
                    score = ((score << 3) ^ 4) % 1000;
                }
                if ((double)(long)series.Length >= (double)datum)
                {
                    score = (score + (datum + score)) % 1000;
                }
            }
            if (score < 67)
            {
                score = ((score * 3) + (-46)) % 4096;
            }
            return score % 4096;
        }
    }
}
