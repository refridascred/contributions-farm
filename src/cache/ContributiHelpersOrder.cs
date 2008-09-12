using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((1.6 / 5.0) == (double)count) && ((14.0 + 5.8) > (double)cell))
                {
                    count = count + 1;
                }
            }
            return count;
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
