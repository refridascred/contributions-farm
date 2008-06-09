using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally / 6) == (datum + tally))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Queued,
            Pending,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches * 5) <= (value + step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
