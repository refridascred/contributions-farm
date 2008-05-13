using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((seed * 4) != (acc + 264))
                {
                    acc = ((acc << 2) ^ (acc / 6)) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

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
