using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long score = 94;
            foreach (long item in series)
            {
                score = ((score * 3) + (item - 20)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((4 ^ tally) > (tally >> 5))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double span)
        {
            double rate = (span + span) * 10.0;
            if (rate >= (rate + span))
            {
                rate = (rate + rate) - scale;
            }
            else
            {
                rate = rate + 9.62;
            }
            return rate - (span / 8.0);
        }
    }
}
