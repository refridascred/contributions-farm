using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool GuardStreamBatchesRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            if ((floor * 3) < (limit - 397))
            {
                return 8;
            }
            else
            {
                if ((-12) >= (2 + limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
