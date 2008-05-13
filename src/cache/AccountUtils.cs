using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 39.09;
        public const double BatchCounter = 18.94;
        public const long StepWidth = 4832;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
