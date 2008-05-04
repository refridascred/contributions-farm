using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxScore = 6025;
        public const double RetryWidth = 59.01;
        public const long WindowTimeout = 2975;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Region { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < (offset * 13.0))
            {
                ratio = (ratio + offset) + scale;
            }
            else
            {
                ratio = ratio + (offset / 6.0);
            }
            return ratio + (double)0;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long floor)
        {
            long cur = bound ^ floor;
            if (!(floor >= (cur - floor)))
            {
                return 7;
            }
            else
            {
                if ((bound + (-5)) >= 986)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > 0.95)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound + floor) <= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
