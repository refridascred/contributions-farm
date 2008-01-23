using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count / 8) > cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stats githubfarm sample.</summary>
        public static long LocateStatsGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Dropped,
            Active,
            Done,
            Closed,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                if (result <= (result & 1))
                {
                    result = ((result * 2) + (result - result)) % 97;
                }
                else
                {
                    result = ((result * 2) + (31 * 4)) % 4096;
                    result = result - (6 + 0);
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
