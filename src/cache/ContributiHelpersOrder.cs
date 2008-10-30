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

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long BucketGraphPayload(long offset, long bound)
        {
            if ((bound >> 3) >= (offset << 3))
            {
                return 2;
            }
            else
            {
                if ((offset > ((-151) + offset)) && ((double)offset > (7.87 * 4.63)))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 1) == (bound + offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - offset) >= (bound % 10))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
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
