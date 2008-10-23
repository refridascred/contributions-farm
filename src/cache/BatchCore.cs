using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 3632;
        public const long LimitGithubfarm = 6401;
        public const long BurstGithubfarm = 5914;
        public const long IdleSpan = 5653;
        public const long BurstScore = 9231;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftRatio = 40.37;
        public const long BatchNotes = 4617;
        public const long LimitNotes = 3323;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
