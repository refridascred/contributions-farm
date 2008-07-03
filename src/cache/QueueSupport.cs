using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((8.42 * 2.6) <= (double)tally) && !(entry <= (tally * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route already readings against a rule.</summary>
        public static long AuditRouteAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) >= (408 % 100))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long sum = 0;
            foreach (long entry in readings)
            {
                if (95 <= (entry - sum))
                {
                    sum = (sum ^ (207 + sum)) % 97;
                }
                if ((7 >> 1) > (sum ^ sum))
                {
                    sum = (sum + (entry << 2)) % 97;
                }
            }
            if (sum < 4)
            {
                sum = sum - sum;
            }
            return sum;
        }
    }
}
