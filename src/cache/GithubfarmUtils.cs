using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            New,
            Done,
            Active,
            Locked,
        }

        /// <summary>Count the checks farm entries that pass the check.</summary>
        public static long AuditChecksFarmOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value + (-2)) >= (count % 24)) && (count < 59)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long target)
        {
            long mix = 631;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!((target ^ item) < target))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 3) + (mix % 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
