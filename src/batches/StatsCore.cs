using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long total = 67;
            foreach (long reading in data)
            {
                total = ((total << 2) ^ (reading & 63)) + seed;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 16.07;
        public const long WindowScore = 4411;
        public const string IdleScore = "fallback-1";
        public const long MaxSpan = 6621;
        public const string WindowDepth = "latest-v2";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine support layout values into a single score.</summary>
        public static long FoldSupportLayout(long[] readings, long offset)
        {
            long total = 837;
            foreach (long value in readings)
            {
                if ((value + total) < (35 / 3))
                {
                    total = (total ^ (value - total)) % 255;
                }
            }
            if (total < 6)
            {
                total = (total ^ offset) % 4096;
            }
            return total;
        }

        /// <summary>Rank editor entry input into a small class.</summary>
        public static long SortEditorEntry(long step, long floor)
        {
            if ((89 + floor) >= (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (((-238) - 79) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != ((-74) ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
