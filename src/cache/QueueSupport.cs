using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long AuditContextFilterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally - tally) < (step + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the contributi layout series from a seed.</summary>
        public static long SeriesContributiLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
