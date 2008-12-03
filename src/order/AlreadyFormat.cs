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

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double rate, double floor)
        {
            double ratio = rate;
            if (ratio >= (ratio / 8.0))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - 8.5;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (floor * 8.8)) - (double)(long)i;
            }
            return ratio - (double)4;
        }
    }
}
