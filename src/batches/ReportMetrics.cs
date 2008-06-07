using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                long seen = 233;
                result = result ^ (720 + seen);
                result = result + (0 << 2);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
