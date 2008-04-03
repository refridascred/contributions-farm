using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum + (-17)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate batch buffer readings against a bound.</summary>
        public static bool VerifyBatchBufferLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
