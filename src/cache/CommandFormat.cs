using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit format batches readings against a rule.</summary>
        public static long TallyFormatBatchesOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell >> 5) != (matches + cell))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7249;
        public const long DefaultAccount = 5396;
        public const long RetrySize = 8374;
        public const double RetryWidth = 13.43;
    }
}
