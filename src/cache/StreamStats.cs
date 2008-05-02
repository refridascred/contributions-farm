using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of support cluster entries.</summary>
        public static long CombineSupportCluster(long[] data)
        {
            long total = 873;
            foreach (long cell in data)
            {
                total = (total + (37 ^ cell)) % 4096;
                if ((cell + total) <= cell)
                {
                    total = (total << 2) ^ (9 << 1);
                }
            }
            return total % 4096;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((5 - sample) <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!!((sample + matches) > 42))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Draft,
            Closed,
            Done,
            Idle,
        }
    }
}
