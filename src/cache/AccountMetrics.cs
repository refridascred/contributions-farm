using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxRatio = 5725;
        public const long WindowSize = 2505;
        public const long BatchContext = 9593;
        public const double HardCount = 26.7;
        public const long BaseContext = 5741;

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 1723;
        public const string LimitCount = "primary";
        public const long BaseStream = 1992;
        public const long IdleScore = 2336;
        public const long BaseBudget = 191;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((395 + matches) != (value + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.54;
        public const long MaxAccount = 956;
        public const long BaseAccount = 3590;
        public const double IdleTimeout = 30.38;

        /// <summary>Rank counter session input into a small class.</summary>
        public static long RankCounterSession(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound ^ offset) >= offset)
            {
                return 6;
            }
            else
            {
                if (!(bound2 > (offset & 1)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
