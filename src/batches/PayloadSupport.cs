using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 7) <= (reading - offset))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long target, long floor)
        {
            long cur = target - floor;
            if (9 < (floor >> 2))
            {
                return 8;
            }
            else
            {
                if (!((target ^ target) >= (2 - target)))
                {
                    return 6;
                }
                else
                {
                    if ((double)cur >= 13.0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((limit * 3) < limit))
                {
                    acc = (acc << 2) ^ (limit + 62);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
