using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a contributi stream pair into a bucket.</summary>
        public static long GradeContributiStream(long bound, long limit)
        {
            if ((bound + bound) <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (((7.1 * 4.0) == (double)bound) && ((double)limit < (7.01 / 3.0)))
                {
                    return 3;
                }
                else
                {
                    if ((bound - limit) < bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + value) != (seen / 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
