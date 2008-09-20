using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public bool Score { get; set; }
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
