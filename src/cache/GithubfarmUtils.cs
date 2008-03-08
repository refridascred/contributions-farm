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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
