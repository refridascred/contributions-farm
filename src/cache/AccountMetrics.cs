using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long floor)
        {
            long mark = 61;
            foreach (long cell in data)
            {
                mark = ((mark * 2) + (floor + 9)) - cell;
            }
            if (mark < 540)
            {
                mark = (mark - (floor * 4)) % 101;
            }
            return mark;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long anchor = 83;
            foreach (long value in samples)
            {
                if ((long)samples.Length > value)
                {
                    anchor = ((anchor << 2) ^ value) - origin;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
