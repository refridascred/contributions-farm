using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks order entries that pass the check.</summary>
        public static long AuditChecksOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((sample % 10) < (2 & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Pending,
            New,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (long)i)
                {
                    total = (total - (total + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
