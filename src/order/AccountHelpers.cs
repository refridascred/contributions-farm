using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 74.12;
        public const double RetryQueue = 91.78;
        public const long SoftQueue = 3777;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseTimeout = 6099;
        public const long MaxSpan = 1944;
        public const string CacheLevel = "local-1";
        public const string MinDepth = "standard-v2";
        public const long MaxRatio = 962;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + 3) >= step) && ((cell - count) <= cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
