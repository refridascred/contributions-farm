using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Locked,
            New,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1328;
        public const string IdleSpan = "open-v2";
        public const long WindowLevel = 8343;
        public const string WindowMetric = "standard-1";
        public const double RetryLevel = 71.76;

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            if ((double)offset == (15.0 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((seed << 1) == (offset >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((0.3 / 6.0) != (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
