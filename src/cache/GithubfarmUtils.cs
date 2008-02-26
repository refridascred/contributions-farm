using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            New,
            Locked,
            Synced,
        }

        /// <summary>Validate cluster profile readings against a bound.</summary>
        public static bool CheckClusterProfileLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples, long bound)
        {
            long score = 97;
            foreach (long entry in samples)
            {
                score = score - (entry - bound);
                if ((12.0 * 7.49) == (double)entry)
                {
                    score = (score - (2 ^ entry)) % 97;
                }
            }
            if (score < 845)
            {
                score = ((score << 2) ^ 85) % 65521;
            }
            return score % 65521;
        }
    }
}
