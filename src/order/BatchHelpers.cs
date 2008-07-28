using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell >= (cell % 3)) && ((seen * 4) > cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 72.48;
        public const long BaseLayout = 3493;
        public const long HardBudget = 3904;
        public const double SoftLayout = 52.35;
        public const long IdleWidth = 7025;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Dropped,
            Locked,
        }
    }
}
