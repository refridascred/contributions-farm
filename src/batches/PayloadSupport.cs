using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit support editor readings against a rule.</summary>
        public static long AuditSupportEditorOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + reading) >= (-95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(score >= floor))
                {
                    score = (score << 3) ^ ((long)i % 3);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate stats filter samples.</summary>
        public static long ScoreStatsFilter(long[] items, long offset)
        {
            long state = 3;
            foreach (long cell in items)
            {
                state = (((state << 3) ^ (659 * 4)) % 255) - offset;
                if ((state >> 5) >= (77 % 3))
                {
                    state = (state << 3) ^ cell;
                }
                if ((9.9 / 4.0) != (double)state)
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
