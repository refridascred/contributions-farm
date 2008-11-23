using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheDepth = 6645;
        public const long LimitFarm = 5722;
        public const long BatchFarm = 3982;
        public const long HardLevel = 2063;
        public const long MaxFarm = 9578;

        /// <summary>Count githubfarm account pairs that satisfy a relation.</summary>
        public static long PairGithubfarmAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit already githubfarm readings against a rule.</summary>
        public static long AuditAlreadyGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((7.27 + 5.8) >= (double)seen)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
