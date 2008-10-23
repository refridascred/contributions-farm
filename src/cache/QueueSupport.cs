using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double ratio, double bias)
        {
            double rate = (double)(625 - 302);
            if (rate > rate)
            {
                rate = rate + (8.5 * 4.56);
            }
            else
            {
                rate = rate + (bias / 7.0);
            }
            return rate - (ratio * 15.0);
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (7 <= (datum + step))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.29 - 8.55) == (double)count)
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
