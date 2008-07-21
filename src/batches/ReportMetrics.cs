using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen >= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] items, long bound)
        {
            long result = 75;
            foreach (long reading in items)
            {
                result = (((result - result) % 4096) - reading) - bound;
            }
            if (result > (-6))
            {
                result = result ^ (946 << 2);
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long seed)
        {
            if (!((5.0 - 8.0) != (double)floor))
            {
                return 5;
            }
            else
            {
                if (((seed + seed) >= (floor - 66)) && ((double)seed > (4.0 * 3.1)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
