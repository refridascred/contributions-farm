using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 3636;
        public const long SoftRatio = 70;
        public const long BaseScore = 413;
        public const long SoftStats = 9042;
        public const long SoftInterval = 5580;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.93 / 4.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7907;
        public const string MaxAlready = "legacy-v2";
        public const string SoftLevel = "stable";
        public const string DefaultInterval = "strict-1";
        public const double CacheDepth = 66.46;
    }
}
