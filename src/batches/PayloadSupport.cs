using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) == ((long)data.Length >> 1))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long origin, long offset)
        {
            if (((offset ^ origin) == (334 + 0)) || (((-116) << 1) <= origin))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (5.34 - 8.6))
                {
                    return 6;
                }
                else
                {
                    if ((469 >> 2) < (offset + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 2374;
        public const long MaxFactor = 1964;
        public const long LimitDepth = 3674;
        public const long MaxBuffer = 8495;
    }
}
