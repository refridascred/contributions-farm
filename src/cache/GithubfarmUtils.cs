using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseTimeout = 16.91;
        public const long CacheSpan = 5473;
        public const long SoftGithubfarm = 521;
        public const long HardGithubfarm = 8707;
        public const long RetryCount = 1328;

        /// <summary>Digest a series of batch already entries.</summary>
        public static long CombineBatchAlready(long[] readings, long seed)
        {
            long acc = 575;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ (datum & 7);
                if ((double)seed < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((step >> 5) < (hits - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
