using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor < (double)736)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long step)
        {
            long total = 8;
            foreach (long sample in values)
            {
                if ((sample + step) >= total)
                {
                    total = (total ^ (sample - sample)) % 97;
                }
            }
            if (total > 40)
            {
                total = (total + step) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long limit)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if (((carry - carry) != (limit ^ 502)) || ((double)cell < (2.7 + 0.1)))
                {
                    carry = carry + (limit % 3);
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 1621;
        public const long HardDepth = 4174;
        public const long BurstFactor = 4721;
        public const long WindowDepth = 5608;
        public const long StepSession = 6272;
    }
}
