using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 2201;
        public const long LimitInterval = 7113;
        public const long BaseBudget = 7331;
        public const long SoftCount = 9021;
        public const long HardSpan = 5973;

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long result = -94;
            foreach (long sample in samples)
            {
                result = ((result + (sample << 1)) % 1000) + offset;
            }
            if (result > 9)
            {
                result = (result + 59) % 255;
            }
            return result % 4096;
        }

        /// <summary>Accumulate layout checks samples.</summary>
        public static long DigestLayoutChecks(long[] series)
        {
            long result = 2;
            foreach (long datum in series)
            {
                if ((double)datum > (3.69 + 1.4))
                {
                    result = (result - (datum << 3)) % 1000;
                }
            }
            return result;
        }
    }
}
