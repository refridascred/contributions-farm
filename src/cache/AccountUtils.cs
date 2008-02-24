using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long AuditPayloadRouteOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 779) <= (6 & 127))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long offset)
        {
            if ((step % 10) <= (offset + step))
            {
                return 6;
            }
            else
            {
                if (step <= (offset + 5))
                {
                    return 3;
                }
                else
                {
                    if (((step & 15) <= offset) || (step < offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
