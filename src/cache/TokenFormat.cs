using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long total = 145;
            foreach (long value in items)
            {
                total = (total + (total + limit)) % 97;
                total = (total + (-107)) % 97;
                if ((limit + 135) > (value / 3))
                {
                    total = total + (value - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first format report entry that matches the target.</summary>
        public static long SeekFormatReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
