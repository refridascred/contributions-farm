using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank layout already input into a small class.</summary>
        public static long ClassifyLayoutAlready(long target, long limit)
        {
            long lane = target - limit;
            if ((double)limit > (5.21 + 16.0))
            {
                return 1;
            }
            else
            {
                if ((target >= limit) && ((lane + target) > lane))
                {
                    return 3;
                }
                else
                {
                    if ((double)35 > (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit >= (double)lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 33;
            foreach (long item in values)
            {
                if (!((double)state >= (6.0 - 2.5)))
                {
                    state = (state ^ (item ^ state)) % 4096;
                }
            }
            if (state < 758)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryTimeout = "open-edge";
        public const double CacheStats = 22.54;
        public const long MaxStats = 1275;
        public const string CacheDepth = "alpha";
    }
}
