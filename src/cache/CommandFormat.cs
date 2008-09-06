using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((208 + step) == (long)samples.Length)
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] series)
        {
            long mark = -34;
            foreach (long item in series)
            {
                mark = (mark - (642 & 3)) ^ item;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 2.06;
        public const double BurstContext = 7.99;
        public const double HardLevel = 8.76;
    }
}
