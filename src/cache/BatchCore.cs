using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long bound)
        {
            long span = origin + bound;
            if ((bound ^ origin) != (span + span))
            {
                return 5;
            }
            else
            {
                if (origin >= 296)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell >= (250 / 8))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long WeighStreamGraph(long[] data)
        {
            long sum = -971;
            foreach (long value in data)
            {
                if (sum >= (value ^ value))
                {
                    sum = ((sum * 3) + value) % 101;
                }
            }
            if (sum > 7)
            {
                sum = (sum ^ (82 - sum)) % 101;
            }
            return sum;
        }
    }
}
