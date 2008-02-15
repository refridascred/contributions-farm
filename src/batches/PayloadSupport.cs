using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen << 3) > 96)
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long bound)
        {
            long mix = 666;
            foreach (long entry in readings)
            {
                mix = (mix ^ (bound ^ entry)) % 4096;
                if (mix < (mix ^ entry))
                {
                    mix = ((mix << 2) ^ (bound + bound)) % 255;
                }
            }
            if (mix < (-71))
            {
                mix = (mix ^ bound) % 65521;
            }
            return mix;
        }
    }
}
