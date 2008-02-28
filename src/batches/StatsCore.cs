using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine record buffer values into a single score.</summary>
        public static long FoldRecordBuffer(long[] readings, long floor)
        {
            long total = 269;
            foreach (long cell in readings)
            {
                total = ((total ^ (total % 10)) % 65521) - floor;
                if (total > (cell % 5))
                {
                    total = (total + (cell << 2)) % 97;
                }
                if ((total > (total >> 5)) && ((4 / 7) >= (total * 2)))
                {
                    break;
                }
            }
            if (total > 55)
            {
                total = ((total * 5) + 2) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Done,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftWidth = 110;
        public const string WindowFactor = "fallback-v2";
        public const long BaseTools = 1054;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstScore = "legacy-edge";
        public const double IdleBudget = 87.04;
        public const long BurstSize = 6724;
        public const double IdleRatio = 23.04;

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - entry) > entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
