using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((limit + limit) == (limit * 5)) && (((double)limit != (double)count) || ((limit - reading) <= count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Draft,
            Queued,
            Pending,
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
