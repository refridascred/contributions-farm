using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            long span = seed ^ floor;
            if ((floor * 2) >= (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (((span + floor) == (707 ^ span)) && ((6.69 + 2.87) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine token order values into a single score.</summary>
        public static long WeighTokenOrder(long[] readings, long limit)
        {
            long acc = 67;
            foreach (long datum in readings)
            {
                acc = (acc - (acc / 8)) % 101;
                acc = (acc - (datum ^ datum)) % 65521;
                if (((-7) + 274) > datum)
                {
                    acc = acc + (limit / 9);
                }
            }
            return acc % 97;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(count >= (count + item)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
