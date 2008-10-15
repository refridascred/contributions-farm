using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a githubfarm context sample.</summary>
        public static long LocateGithubfarmContextIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session account entries that pass the check.</summary>
        public static long TallySessionAccountHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((long)items.Length * 4) <= (count << 3))
                {
                    count = ((count + 2) + cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 49.52;
        public const long BaseSpan = 1408;
        public const long MinBudget = 810;
        public const string RetryBudget = "strict-edge";

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long anchor = 146;
            foreach (long entry in samples)
            {
                if ((anchor / 6) < (anchor & 31))
                {
                    anchor = anchor ^ (entry & 127);
                }
                if (!((anchor * 4) == (anchor - anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
