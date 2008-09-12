using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((double)item < (13.0 - 9.0)))
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
