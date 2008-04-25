using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((919 + count) != (entry << 3))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 6027;
        public const long IdleOrder = 5983;
        public const long RetryRatio = 6964;

        /// <summary>Compare every pair of route githubfarm readings.</summary>
        public static long OverlapRouteGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
