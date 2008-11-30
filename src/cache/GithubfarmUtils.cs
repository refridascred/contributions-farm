using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((15 - seen) <= (bound - bound))
                {
                    seen = (seen + 1) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools notes series from a seed.</summary>
        public static long SeriesToolsNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = sum + (sum + (long)i2);
                }
                sum = (sum ^ (-916)) % 255;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long TallyFilterStreamGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)limit <= (7.0 * 3.1))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
