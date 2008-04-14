using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long LocateContextSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Locked,
            Stale,
            Closed,
            Failed,
            Synced,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long target)
        {
            long edge = bound ^ target;
            if (!((target - edge) >= (bound + 4)))
            {
                return 1;
            }
            else
            {
                if ((double)(-206) <= (double)edge)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long target)
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
    }
}
