using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long score = 7;
            foreach (long reading in items)
            {
                if ((0 / 2) != (reading + bound))
                {
                    score = (score - (score + score)) % 97;
                }
            }
            return score;
        }

        /// <summary>Audit batch profile readings against a rule.</summary>
        public static long MeasureBatchProfileGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally < (double)datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
