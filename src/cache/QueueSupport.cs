using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool ValidateContextCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long floor, long step)
        {
            long diff = floor ^ step;
            if (((step + floor) < (diff & 3)) && (9 < floor))
            {
                return 2;
            }
            else
            {
                if (((step / 5) <= diff) || ((diff - 33) <= (step * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((diff + step) > (27 % 64))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool VerifyStatsLayoutRange(long[] items, long target)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
