using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks queue value from a seed.</summary>
        public static long IterateChecksQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ (302 + mark)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4548;
        public const long StepReport = 571;
        public const long MinWidth = 5026;
        public const string SoftReport = "strict-v2";
    }
}
