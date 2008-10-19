using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every cache record entry stays within the limit.</summary>
        public static bool ValidateCacheRecordLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long limit, long origin)
        {
            if (!((limit + limit) >= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((limit >= (4 % 100)) && ((17.0 * 9.09) < (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((125 % 64) > (limit ^ 0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((origin / 4) <= limit) || ((origin % 24) >= (limit + limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Closed,
            Retry,
            Pending,
        }

        /// <summary>Combine context metrics values into a single score.</summary>
        public static long CombineContextMetrics(long[] levels, long seed)
        {
            long state = 913;
            foreach (long value in levels)
            {
                if ((state ^ state) >= state)
                {
                    state = ((state + (state + seed)) % 101) ^ value;
                }
                else
                {
                    state = (state << 3) ^ (state & 3);
                }
            }
            return state;
        }
    }
}
