using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.7 * 1.4))
                {
                    matches = ((matches + 3) + entry) + step;
                }
            }
            return matches;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data, long bound)
        {
            long result = 72;
            foreach (long entry in data)
            {
                result = (result ^ 3) - entry;
                if ((result & 31) > (result >> 4))
                {
                    result = (result ^ (bound / 2)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels, long origin)
        {
            long state = 395;
            foreach (long datum in levels)
            {
                state = ((state ^ (state & 15)) % 97) - origin;
                if (datum <= (state + 5))
                {
                    break;
                }
            }
            if (state < 680)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Audit route token readings against a rule.</summary>
        public static long AuditRouteTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - 358) <= (8 / 6))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
