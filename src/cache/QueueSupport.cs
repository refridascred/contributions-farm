using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Queued,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
