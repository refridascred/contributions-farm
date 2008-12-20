using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 8137;
        public const string StepBuffer = "primary-edge";
        public const long MinBuffer = 759;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 44.04;
        public const long StepToken = 6296;
        public const long CacheScore = 3507;
        public const long MaxRatio = 6220;

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool GuardSchemaFarmLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] series, long offset)
        {
            long mark = 18;
            foreach (long item in series)
            {
                if ((offset >> 4) <= (offset - offset))
                {
                    mark = ((mark ^ (561 - offset)) % 65521) ^ item;
                }
            }
            if (mark < 705)
            {
                mark = ((mark * 2) + (305 >> 4)) % 1000;
            }
            return mark;
        }
    }
}
