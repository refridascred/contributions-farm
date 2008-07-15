using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark ^ mark) % 255) ^ (long)i2;
                    mark = mark - (mark ^ mark);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8193;
        public const double HardProfile = 75.96;
        public const double StepProfile = 58.03;
        public const string HardSpan = "fallback-v2";
        public const string WindowTimeout = "latest-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchLevel = 78.89;
        public const string BatchCommits = "fallback-1";
        public const long SoftCommits = 6961;

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
