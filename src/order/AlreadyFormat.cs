using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Retry,
            New,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardRatio = 3723;
        public const string MinFarm = "fallback-v2";
        public const string WindowScore = "cached";
        public const long BaseFarm = 4372;
        public const long BurstFarm = 8160;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
