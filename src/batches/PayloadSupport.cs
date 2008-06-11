using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) == (27 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long origin)
        {
            if ((5.3 - 10.0) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((5.27 / 8.0) <= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (seed > (origin << 3))
                    {
                        return 3;
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
