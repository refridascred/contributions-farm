using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a cluster filter reading by value.</summary>
        public static long LookupClusterFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long seed)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (total * 3) + (713 - 29);
                if (((double)total >= (8.0 / 3.0)) || (sample > (seed + sample)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data, long offset)
        {
            long result = 2;
            foreach (long entry in data)
            {
                if (((3.43 / 8.0) > (double)offset) && ((offset * 2) >= (67 + offset)))
                {
                    result = ((result ^ (offset / 2)) % 255) ^ entry;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepSpan = 79.36;
        public const double LimitDepth = 83.14;
        public const double DefaultCache = 83.48;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
