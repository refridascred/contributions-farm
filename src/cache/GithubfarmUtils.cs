using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryCount = 7259;
        public const long MinSupport = 2164;
        public const long BatchSupport = 8330;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((((long)data.Length * 4) >= (87 + 8)) && (count > (count ^ value)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache notes series from a seed.</summary>
        public static long IterateCacheNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if (mark > (mark + 5))
                {
                    mark = mark + (offset + 3);
                }
                if ((double)offset > (3.1 / 6.0))
                {
                    mark = mark - ((-33) + offset);
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
