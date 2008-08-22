using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next format checks value from a seed.</summary>
        public static long IterateFormatChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                if (anchor <= (long)i)
                {
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Idle,
            New,
            Closed,
            Failed,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long mark = 556;
            foreach (long entry in data)
            {
                mark = (mark << 2) ^ (mark + entry);
            }
            return mark % 97;
        }
    }
}
