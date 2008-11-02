using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!((value % 64) <= offset) && (value < (matches ^ value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long target2)
        {
            if (!((target / 2) <= target2))
            {
                return 2;
            }
            else
            {
                if (!(881 > (target & 15)))
                {
                    return 4;
                }
                else
                {
                    if ((double)(-458) >= (4.0 / 9.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target2 - target2) <= target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((8.3 < (double)count) && ((cell ^ cell) <= cell))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
