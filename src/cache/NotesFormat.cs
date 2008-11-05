using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric schema entries that pass the check.</summary>
        public static long TallyMetricSchemaMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 2) <= cell)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
