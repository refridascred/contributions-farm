using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long target, long seed)
        {
            long prev = target - seed;
            if ((((-71) % 60) != (prev / 6)) && ((target & 3) >= 85))
            {
                return 6;
            }
            else
            {
                if ((target + target) > (prev + seed))
                {
                    return 4;
                }
                else
                {
                    if (((prev / 3) == (target + 20)) && ((target - target) < (prev + prev)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleDepth = 53.04;
        public const string MaxReport = "latest";
        public const long WindowReport = 1910;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value <= seen) && (seen >= (seen ^ seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitScore = 2610;
        public const string BurstSpan = "strict-edge";
        public const long BaseTimeout = 637;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Closed,
            Done,
            Pending,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
