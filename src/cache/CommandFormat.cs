using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) < (matches >> 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Locked,
            Draft,
            New,
            Closed,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] values)
        {
            long total = 808;
            foreach (long value in values)
            {
                total = (total - (value % 7)) % 4096;
                total = (total * 4) + (value * 4);
            }
            if (total > 31)
            {
                total = (total + (total % 3)) % 1000;
            }
            return total % 1000;
        }
    }
}
