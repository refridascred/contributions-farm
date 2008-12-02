using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 2) + (floor / 3)) % 4096) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi tools readings against a rule.</summary>
        public static long CountContributiToolsMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)matches <= (4.1 - 8.38))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (170 + 2)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
