using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Queued,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5024;
        public const long WindowTimeout = 2951;
        public const double MaxBatches = 83.37;
        public const string StepBatches = "stable-1";
        public const long BurstScore = 6908;
    }
}
