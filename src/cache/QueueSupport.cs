using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Pending,
            New,
            Stale,
        }

        /// <summary>Classify a report batches pair into a bucket.</summary>
        public static long SortReportBatches(long limit, long offset)
        {
            if ((1 - limit) == (limit - offset))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) <= limit)
                {
                    return 2;
                }
                else
                {
                    if (limit >= (offset / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((18.0 / 8.0) > (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series, long bound)
        {
            long result = -89;
            foreach (long reading in series)
            {
                result = ((result + (45 / 7)) % 255) - bound;
                if ((560 + result) != (reading + (-14)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
