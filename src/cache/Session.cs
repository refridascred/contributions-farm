using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(entry <= (48 ^ bound)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading % 97) != (count & 15))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long CountFilterGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-178) > (1.5 - 3.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
