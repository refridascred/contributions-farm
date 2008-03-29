using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state << 3) ^ 1) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the payload session series from a seed.</summary>
        public static long IteratePayloadSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftWidth = 1018;
        public const long HardRatio = 1409;
        public const long RetryRatio = 3402;
        public const long HardChannel = 3524;
        public const long WindowChannel = 346;
    }
}
