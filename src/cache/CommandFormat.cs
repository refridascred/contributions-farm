using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + count) > (cell % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the layout stream entries that pass the check.</summary>
        public static long CountLayoutStreamOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((seed + value) < (0 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item > (double)89)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(10.0 <= (double)count))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }
    }
}
