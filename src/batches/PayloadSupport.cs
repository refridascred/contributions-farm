using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((380 < limit) && ((long)readings.Length == (count & 255))))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long prev = step ^ target;
            if ((target << 3) <= (target * 2))
            {
                return 7;
            }
            else
            {
                if (7.0 < (double)prev)
                {
                    return 6;
                }
                else
                {
                    if ((prev + 837) >= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
