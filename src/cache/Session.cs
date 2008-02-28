using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((15.0 * 19.0) != (double)tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
