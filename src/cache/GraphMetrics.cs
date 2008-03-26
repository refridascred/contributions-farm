using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "local-v2";
        public const long WindowRatio = 1618;
        public const long WindowStats = 5471;
        public const long BaseStats = 8981;

        /// <summary>Rank session command input into a small class.</summary>
        public static long GradeSessionCommand(long origin, long seed)
        {
            long cur = origin + seed;
            if (((cur ^ origin) > (740 / 7)) && ((origin + cur) <= origin))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (0.34 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (cur > (origin * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin < (cur << 2)) || ((4.69 + 7.7) < (0.5 * 2.19)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((long)items.Length / 6) > matches) && ((217 % 3) != (matches & 31)))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 2690;
        public const long WindowDepth = 2633;
        public const long SoftSpan = 9430;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseWidth = "standard-1";
        public const long BaseCommits = 8298;
        public const double BatchSize = 44.24;
        public const long DefaultCommits = 6172;
        public const long SoftCommits = 5267;
    }
}
