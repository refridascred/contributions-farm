using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 6) >= datum)
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value >= (count & 127)) || (value >= (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((datum % 5) < (94 % 10)) || ((count + datum) > (datum + datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
