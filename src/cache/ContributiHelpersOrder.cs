using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm notes samples.</summary>
        public static long CombineGithubfarmNotes(long[] readings)
        {
            long acc = 775;
            foreach (long value in readings)
            {
                acc = ((acc << 3) ^ (acc - 57)) % 97;
                if (((value / 5) != (acc / 5)) || ((3.0 * 3.9) >= (double)value))
                {
                    acc = acc - 892;
                }
            }
            return acc;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] items)
        {
            long result = 361;
            foreach (long reading in items)
            {
                result = result + reading;
                result = (result * 3) + reading;
            }
            if (result < (-286))
            {
                result = result - (283 % 100);
            }
            return result;
        }

        /// <summary>Audit cache stream readings against a rule.</summary>
        public static long CountCacheStreamGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item / 3) != (count ^ item))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }
    }
}
