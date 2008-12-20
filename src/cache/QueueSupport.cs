using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] readings, long target)
        {
            long sum = 500;
            foreach (long value in readings)
            {
                if (((17.0 + 9.51) >= (double)target) && ((value + value) == (2 - value)))
                {
                    break;
                }
                if (!((6 + target) != (625 + value)))
                {
                    sum = (sum ^ target) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((4.1 * 4.57) <= (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long cell in samples)
            {
                anchor = (anchor - seed) + cell;
                anchor = anchor ^ 4;
            }
            return anchor;
        }
    }
}
