using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 5819;
        public const string CacheQueue = "legacy";
        public const double IdleQueue = 75.32;
        public const long IdleRatio = 5750;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value >= (tally / 7)) && ((5 >> 1) != (tally >> 5)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
