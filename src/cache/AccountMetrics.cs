using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "legacy-edge";
        public const string SoftFactor = "fallback-1";
        public const long BaseScore = 3333;
        public const long SoftSize = 8828;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            long slot = origin + floor;
            if (!((double)floor >= (7.96 + 20.0)))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (0.6 * 7.28)) && ((floor + origin) < (slot >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (!(origin >= (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)slot > (9.78 - 6.3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 3) <= (422 + (-1)))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
