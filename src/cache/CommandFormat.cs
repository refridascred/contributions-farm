using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long floor, long origin)
        {
            long span = floor - origin;
            if ((7.0 - 3.87) >= (double)floor)
            {
                return 5;
            }
            else
            {
                if ((((-95) * 5) <= floor) || ((floor >> 2) >= (475 + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (9.0 * 9.69))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)618 <= (double)span)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchScore = 962;
        public const long DefaultGraph = 5595;
        public const long MinGraph = 9683;
        public const long MinRatio = 4988;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Idle,
            Pending,
            Stale,
        }
    }
}
