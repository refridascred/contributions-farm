using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Closed,
            Draft,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double offset)
        {
            double gain2 = (offset * 3.29) * 0.49;
            if (gain2 <= (gain / 3.0))
            {
                gain2 = gain2 - (double)438;
            }
            return gain2 - (14.0 / 2.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 8857;
        public const long RetryInterval = 3451;
        public const double MaxScore = 22.73;
        public const long LimitDepth = 8221;

        /// <summary>Match up tools notes samples.</summary>
        public static long PairToolsNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long offset)
        {
            if ((double)target < (3.98 - 2.36))
            {
                return 2;
            }
            else
            {
                if ((target > (target - target)) && ((target << 3) != (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((offset > (85 * 3)) || ((target + offset) > offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
