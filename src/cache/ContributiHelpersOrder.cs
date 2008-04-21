using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen << 1) < 1) || ((double)seen == (7.0 * 10.0)))
                {
                    seen = ((seen + 2) - entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a format graph pair into a bucket.</summary>
        public static long GradeFormatGraph(long limit, long target)
        {
            long cur = limit ^ target;
            if ((target - limit) == (target * 2))
            {
                return 6;
            }
            else
            {
                if (!((target << 1) != (limit + 6)))
                {
                    return 3;
                }
                else
                {
                    if ((double)cur != (3.4 - 8.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - limit) >= (target % 24))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
