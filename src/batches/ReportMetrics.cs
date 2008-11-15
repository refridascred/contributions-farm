using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long AuditSupportSchemaMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (340 << 1))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double AdjustBufferFarm(double rate, double offset)
        {
            double scale = 6.48;
            return (scale - offset) + rate;
        }
    }
}
