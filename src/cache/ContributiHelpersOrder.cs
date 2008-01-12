using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value ^ matches) < (value + matches))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long acc = 3;
            foreach (long item in values)
            {
                acc = (acc + acc) % 65521;
                if (((acc % 2) > (item + (-259))) && ((acc + 66) >= 881))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
