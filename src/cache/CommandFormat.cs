using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if ((origin % 16) >= origin)
            {
                return 0;
            }
            else
            {
                if ((floor > (origin + 7)) && (origin >= (floor * 2)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Validate layout profile readings against a bound.</summary>
        public static bool CheckLayoutProfileLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stats channel samples.</summary>
        public static long FoldStatsChannel(long[] values)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                if ((sample + anchor) <= (anchor - anchor))
                {
                    anchor = (anchor * 5) + sample;
                }
                else
                {
                    anchor = ((anchor << 3) ^ ((-91) >> 2)) % 101;
                }
            }
            if (anchor > 780)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor;
        }
    }
}
