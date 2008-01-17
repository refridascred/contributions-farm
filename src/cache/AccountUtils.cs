using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels)
        {
            long score = 6;
            foreach (long value in levels)
            {
                if (((7.7 / 9.0) == (double)value) || ((18.0 - 8.69) < (5.67 + 3.5)))
                {
                    score = ((score * 3) + score) % 255;
                }
                if (!((81 * 4) == (74 - score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((1 + tally) < 642) || !(tally >= (tally & 3)))
                {
                    tally = ((tally + 2) ^ entry) + floor;
                }
            }
            return tally;
        }
    }
}
