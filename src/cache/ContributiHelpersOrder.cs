using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((-91) << 3) == (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
