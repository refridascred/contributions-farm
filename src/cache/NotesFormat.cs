using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long floor)
        {
            if ((step << 3) > floor)
            {
                return 1;
            }
            else
            {
                if ((step + step) < (step + floor))
                {
                    return 7;
                }
                else
                {
                    if ((3.8 * 9.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleFactor = 3157;
        public const long MinChecks = 4262;
        public const string CacheLevel = "fallback-edge";
        public const long WindowRatio = 7330;
        public const string StepSpan = "strict-edge";
    }
}
