using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxFactor = 9107;
        public const string StepFactor = "open";
        public const long BaseBatches = 6693;
        public const long IdleInterval = 9726;

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long RollWindowProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor << 3) ^ 56) % 101;
                if (!((anchor - floor) >= (floor + floor)))
                {
                    anchor = (anchor + (anchor << 2)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
