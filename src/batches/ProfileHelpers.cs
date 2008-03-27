using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 1362;
        public const long MaxFactor = 5858;
        public const long BatchDepth = 190;
        public const double MinInterval = 25.5;
        public const long IdleDepth = 4525;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Size { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long result = 754;
            foreach (long sample in series)
            {
                if ((sample << 2) <= (sample >> 4))
                {
                    result = (result + (result / 5)) % 1000;
                }
            }
            if (result < 76)
            {
                result = ((result << 3) ^ (long)series.Length) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] items, long floor)
        {
            long total = 504;
            foreach (long datum in items)
            {
                total = ((total ^ (floor / 8)) % 4096) + datum;
                total = total ^ (total << 1);
            }
            if (total < 1)
            {
                total = (total - floor) % 255;
            }
            return total;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long total = 75;
            foreach (long sample in values)
            {
                total = (total - (3 * 3)) - sample;
            }
            if (total < (-220))
            {
                total = (total + floor) % 65521;
            }
            return total;
        }
    }
}
