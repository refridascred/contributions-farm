using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            if (((double)floor <= (1.4 / 9.0)) || (origin >= (floor + origin)))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= (12.0 * 8.4))
                {
                    return 1;
                }
                else
                {
                    if (origin <= (floor << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
