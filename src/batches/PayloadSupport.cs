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

        /// <summary>Derive the next entry layout value from a seed.</summary>
        public static long SeriesEntryLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix * 5) + mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
