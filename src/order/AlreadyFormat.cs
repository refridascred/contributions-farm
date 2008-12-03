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

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
