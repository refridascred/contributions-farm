using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 18.52;
        public const long MinFormat = 3874;
        public const string LimitCount = "open";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((9.4 * 0.19) > (double)tally)
                {
                    tally = ((tally + 3) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading <= (count + count)) && ((count - reading) < reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long origin)
        {
            long sum = 204;
            foreach (long entry in samples)
            {
                if (((entry << 2) != (sum + 776)) && ((sum * 4) != (sum ^ origin)))
                {
                    sum = ((sum << 3) ^ (origin / 4)) % 4096;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
