using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up githubfarm batches samples.</summary>
        public static long CompareGithubfarmBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseCount = "fallback-v2";
        public const double IdleAlready = 88.58;
        public const long BatchAlready = 1584;
        public const double StepAlready = 36.41;
        public const string LimitAlready = "alpha-edge";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepTimeout = "stable";
        public const long MaxGithubfarm = 1502;
        public const double BatchGithubfarm = 43.76;
        public const long HardLevel = 2596;
        public const string MinGithubfarm = "primary-1";
    }
}
