using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 4750;
        public const double LimitGithubfarm = 71.07;
        public const double BaseWidth = 21.01;
        public const long MinSize = 6108;
        public const long SoftScore = 1130;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + value) <= (value - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
