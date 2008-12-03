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

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "open-v2";
        public const string MaxRecord = "fallback-edge";
        public const double DefaultScore = 35.96;
        public const string BurstRecord = "latest-1";

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)limit >= (2.0 / 2.0))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
