using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long acc = 29;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc + acc)) % 1000) + entry;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count & 255) <= (count + count)) && ((value <= (value ^ value)) && (value > (count - count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long target)
        {
            long step = bound + target;
            if ((step ^ target) > step)
            {
                return 5;
            }
            else
            {
                if (bound <= (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((step / 3) == (target << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
