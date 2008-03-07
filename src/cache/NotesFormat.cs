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

        /// <summary>Find the first farm contributi entry that matches the target.</summary>
        public static long FindFarmContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
