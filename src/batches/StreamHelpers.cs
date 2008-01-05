using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                sum = (sum ^ (target / 5)) % 65521;
                sum = sum - ((long)series.Length + reading);
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public bool Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Audit tools notes readings against a rule.</summary>
        public static long TallyToolsNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((76 / 6) == ((-3) - tally))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
