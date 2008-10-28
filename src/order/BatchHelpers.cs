using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 184;
            foreach (long sample in readings)
            {
                total = ((total - (total & 255)) % 1000) ^ sample;
            }
            return total % 97;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (806 <= (seen % 10))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
