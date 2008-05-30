using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 4763;
        public const double MaxLevel = 33.43;
        public const double LimitGithubfarm = 50.08;

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long limit)
        {
            long sum = 55;
            foreach (long sample in levels)
            {
                if (53 <= limit)
                {
                    sum = (sum << 2) ^ sample;
                }
            }
            if (sum > 65)
            {
                sum = sum - (50 + sum);
            }
            return sum;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchContext = "standard-v2";
        public const long DefaultLevel = 590;
        public const double SoftContext = 59.38;
    }
}
