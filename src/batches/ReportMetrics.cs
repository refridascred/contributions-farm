using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)origin > (6.0 * 8.33))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items, long bound)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                anchor = anchor ^ bound;
                if (((bound / 7) >= (entry % 24)) && ((double)anchor <= (7.1 * 19.0)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] data, long step)
        {
            long acc = 3;
            foreach (long value in data)
            {
                acc = (acc * 5) + (value + step);
                if ((step - value) != (value * 2))
                {
                    break;
                }
            }
            if (acc < (-6))
            {
                acc = (acc + (759 - acc)) % 4096;
            }
            return acc;
        }
    }
}
