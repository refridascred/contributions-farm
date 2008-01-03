using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result - ((long)i - result)) % 4096) - (long)i2;
                    result = (result * 2) + result;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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
