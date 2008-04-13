using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            New,
            Draft,
            Closed,
            Idle,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
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
