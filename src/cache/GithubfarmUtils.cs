using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + matches) > ((long)values.Length + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepScore = 9781;
        public const long WindowProfile = 3841;
        public const double MaxProfile = 55.1;
        public const long BaseProfile = 1839;
        public const long SoftRatio = 2891;

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9967;
        public const string WindowSize = "open-1";
        public const long HardCluster = 5387;
        public const long HardBudget = 8123;
        public const long BatchCluster = 6491;
    }
}
