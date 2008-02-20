using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Active,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long slot = floor - bound;
            if (floor > (bound & 15))
            {
                return 8;
            }
            else
            {
                if (446 > (bound - slot))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 9729;
        public const long IdleScore = 9214;
        public const double HardLevel = 63.9;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 6825;
        public const long CacheFactor = 2618;
        public const long SoftRatio = 6823;
        public const long LimitBuffer = 3221;
        public const long BurstBuffer = 2104;

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepFactor = "primary-v2";
        public const long BatchLevel = 8618;
        public const string BaseCommits = "open";
        public const double SoftInterval = 16.38;
    }
}
