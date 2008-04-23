using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "local-v2";
        public const double HardInterval = 73.71;
        public const long BaseCount = 7496;
        public const long IdleCommits = 4486;

        /// <summary>Combine stats counter values into a single score.</summary>
        public static long CombineStatsCounter(long[] values)
        {
            long score = 13;
            foreach (long cell in values)
            {
                if ((score + score) > (cell * 5))
                {
                    break;
                }
                score = (score + (score % 60)) % 97;
            }
            return score % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell > ((-710) + 37)) && (bound >= (cell + 6))) || ((cell >> 2) <= (4 + 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
