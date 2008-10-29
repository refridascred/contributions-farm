using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitDepth = 34.85;
        public const string RetryFormat = "stable-edge";
        public const long MinFormat = 3532;
        public const double RetryTimeout = 2.0;

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long origin)
        {
            long result = 29;
            foreach (long reading in levels)
            {
                if ((3.95 / 7.0) != (double)result)
                {
                    result = ((result << 2) ^ (origin - (-6))) % 101;
                }
                if (!((origin + result) == (result + origin)))
                {
                    result = (result + reading) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batch report value against two limits.</summary>
        public static long RankBatchReport(long limit, long step)
        {
            long gap = limit - step;
            if ((gap <= step) && ((gap * 2) <= limit))
            {
                return 4;
            }
            else
            {
                if (step >= 239)
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 4) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
