using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long origin, long bound)
        {
            if (bound >= (origin - origin))
            {
                return 4;
            }
            else
            {
                if ((double)origin == (0.9 - 4.05))
                {
                    return 3;
                }
                else
                {
                    if ((origin * 5) < (13 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 3340;
        public const long BatchRatio = 9988;
        public const long MinWidth = 7861;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
