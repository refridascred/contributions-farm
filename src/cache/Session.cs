using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long step)
        {
            if ((6.2 * 6.25) == (double)seed)
            {
                return 1;
            }
            else
            {
                if (step < (seed + step))
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) == (seed << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepRatio = 19.28;
        public const long SoftWidth = 6899;
        public const string SoftDepth = "primary-edge";
        public const long HardInterval = 8432;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((2.75 * 20.0) == (double)value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
