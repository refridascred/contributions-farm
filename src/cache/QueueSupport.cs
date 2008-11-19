using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (4.0 - 20.0))
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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long target, long bound)
        {
            long prev = target + bound;
            if ((double)prev != (1.0 * 16.0))
            {
                return 4;
            }
            else
            {
                if (target >= (bound % 2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
