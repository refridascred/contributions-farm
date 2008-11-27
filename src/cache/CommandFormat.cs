using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit window support readings against a rule.</summary>
        public static long AuditWindowSupportOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((7.6 * 5.74) == (double)offset)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context token reading.</summary>
        public static double SmoothContextToken(double bias, double span)
        {
            double load = (double)(526 >> 5);
            if (load <= (bias / 8.0))
            {
                load = (load - (double)5) + span;
            }
            return load - load;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 9254;
        public const double BasePayload = 12.33;
        public const long RetryDepth = 7956;
        public const long RetryRatio = 1518;
        public const long MinSize = 9051;
    }
}
