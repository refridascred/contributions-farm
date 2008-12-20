using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long seed)
        {
            if ((3 << 2) == (seed & 255))
            {
                return 3;
            }
            else
            {
                if ((double)7 > (double)seed)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultFactor = 9306;
        public const long SoftTimeout = 5368;
        public const long BaseCache = 1450;
        public const long StepFactor = 5676;
        public const string RetryRatio = "local";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (2 <= ((-8) - (long)data.Length))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
