using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen << 1) <= (datum << 3)) && ((datum + seen) < (seen + datum)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            Dropped,
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long floor)
        {
            if (target > (target & 63))
            {
                return 8;
            }
            else
            {
                if ((target + target) > floor)
                {
                    return 3;
                }
                else
                {
                    if (!((target - target) <= (target >> 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 6) > (2 % 100))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (7.7 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
