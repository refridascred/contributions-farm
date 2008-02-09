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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
