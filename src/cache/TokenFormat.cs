using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Total { get; set; } = "";
            public long Region { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Find the first metric stats entry that matches the target.</summary>
        public static long LookupMetricStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
