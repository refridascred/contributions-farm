using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 9014;
        public const double StepSize = 50.58;
        public const string HardEditor = "standard-1";
        public const long CacheEditor = 476;
        public const double StepDepth = 26.06;

        /// <summary>Grade a window entry value against two limits.</summary>
        public static long GradeWindowEntry(long step, long floor)
        {
            long span = step - floor;
            if ((double)span <= 2.75)
            {
                return 1;
            }
            else
            {
                if ((step % 64) == (floor ^ span))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
