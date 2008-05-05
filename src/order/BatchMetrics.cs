using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long limit)
        {
            if (!((-4) <= (42 + limit)))
            {
                return 3;
            }
            else
            {
                if (((65 << 3) > (bound - limit)) || ((860 / 2) > limit))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 7) < (limit - bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 1606;
        public const long LimitWindow = 9057;
        public const long MaxTimeout = 1936;
        public const long BaseWindow = 3925;
        public const string HardBudget = "alpha-1";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
