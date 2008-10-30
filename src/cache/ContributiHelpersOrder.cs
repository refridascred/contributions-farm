using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(5 < (hits - sample)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long target)
        {
            long prev = offset ^ target;
            if (!((586 << 3) <= (offset % 16)))
            {
                return 6;
            }
            else
            {
                if ((1.2 / 8.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((prev << 2) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
