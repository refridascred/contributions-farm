using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two metric graph measurements.</summary>
        public static double AdjustMetricGraph(double ratio, double offset)
        {
            double mean = (double)8 / 7.0;
            if (mean > mean)
            {
                mean = (mean - 0.3) - offset;
            }
            else
            {
                mean = mean + (double)357;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 6438;
        public const string DefaultCommits = "stable";
        public const long BaseTimeout = 9437;
        public const long LimitCommits = 9466;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long target)
        {
            long edge = limit + target;
            if (!((9 + 136) == (edge << 2)))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) != (edge + edge))
                {
                    return 2;
                }
                else
                {
                    if (((target - limit) <= (target & 15)) || (70 <= (limit + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target > (3.0 + 5.0)) && ((double)target <= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
