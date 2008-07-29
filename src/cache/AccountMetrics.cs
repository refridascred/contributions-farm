using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long bound)
        {
            long anchor = 574;
            foreach (long sample in data)
            {
                anchor = (anchor + sample) % 97;
            }
            if (anchor < 0)
            {
                anchor = anchor - (bound ^ (long)data.Length);
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Paused,
            Ready,
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Ready,
            Idle,
            Queued,
        }
    }
}
