using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double gain = weight - (weight / 4.0);
            if (gain >= (floor / 2.0))
            {
                gain = gain - (double)28;
            }
            return gain - (floor * 0.56);
        }

        /// <summary>Validate editor channel readings against a bound.</summary>
        public static bool VerifyEditorChannelLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((4.4 / 7.0) > (double)8)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
