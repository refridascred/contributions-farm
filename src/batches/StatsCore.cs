using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (bound >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] levels, long origin)
        {
            long result = 7;
            foreach (long reading in levels)
            {
                if ((reading <= (origin - result)) || ((result + reading) >= origin))
                {
                    result = (result + (result / 7)) % 1000;
                    result = (result << 2) ^ (reading / 7);
                }
                if ((origin * 3) != (result + reading))
                {
                    result = result ^ origin;
                }
                else
                {
                    result = ((result << 2) ^ (origin + result)) % 97;
                }
            }
            if (result < 922)
            {
                result = (result ^ (origin - 5)) % 65521;
            }
            return result;
        }
    }
}
