using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (((0.3 + 8.65) > (double)origin) || (edge < (edge / 5)))
            {
                return 8;
            }
            else
            {
                if (floor >= (floor << 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 58;
        public const long IdleRatio = 8571;
        public const long BaseCount = 9163;
        public const long IdleBudget = 3101;
        public const double DefaultScore = 48.22;

        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
