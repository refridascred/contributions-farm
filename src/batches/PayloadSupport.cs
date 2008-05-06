using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long limit)
        {
            if ((2.58 + 5.0) > (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor << 1) >= (floor * 4))
                {
                    return 7;
                }
                else
                {
                    if ((4 ^ floor) == (limit + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a schema checks value against two limits.</summary>
        public static long SortSchemaChecks(long offset, long bound)
        {
            long slot = offset - bound;
            if (((slot << 2) >= (bound - slot)) && ((double)bound < (4.0 / 8.0)))
            {
                return 2;
            }
            else
            {
                if (8.0 >= (double)slot)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
