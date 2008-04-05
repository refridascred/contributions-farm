using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseRatio = 9968;
        public const long CacheAlready = 1951;
        public const long SoftAlready = 2792;
        public const long BaseAlready = 8339;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
