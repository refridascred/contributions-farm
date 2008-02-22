using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 5334;
        public const long HardMetrics = 9344;
        public const long CacheMetrics = 7248;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long step, long offset)
        {
            if (((918 ^ step) == (171 + step)) || ((offset + step) <= (offset % 8)))
            {
                return 3;
            }
            else
            {
                if (!((offset - offset) > (step % 64)))
                {
                    return 1;
                }
                else
                {
                    if ((step & 63) != (step % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2 << 2) != (step / 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
