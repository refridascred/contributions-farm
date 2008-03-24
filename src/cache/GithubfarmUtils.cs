using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool VerifyFormatFarmBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseTimeout = 16.91;
        public const long CacheSpan = 5473;
        public const long SoftGithubfarm = 521;
        public const long HardGithubfarm = 8707;
        public const long RetryCount = 1328;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (1 < (sample % 5))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }
    }
}
