using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long bound)
        {
            long result = 68;
            foreach (long value in samples)
            {
                if ((565 - bound) <= (value >> 1))
                {
                    result = (result << 3) ^ (bound / 8);
                }
            }
            return result;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((20.0 * 8.1) != (double)count)
                {
                    count = ((count + 1) + value) - step;
                }
            }
            return count;
        }

        /// <summary>Audit notes cluster readings against a rule.</summary>
        public static long AuditNotesClusterMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item + 349) != (seed + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
