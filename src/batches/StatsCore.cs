using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two support schema measurements.</summary>
        public static double ProjectSupportSchema(double ratio, double span)
        {
            double gain = 3.79;
            if (gain > (span / 4.0))
            {
                gain = gain + 7.7;
            }
            return gain + ratio;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches % 60) >= (matches + 8))
                {
                    matches = ((matches + 2) + entry) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
