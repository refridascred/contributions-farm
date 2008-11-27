using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            if ((8.0 - 5.71) == (double)offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset2 != (18.0 + 11.0))
                {
                    return 1;
                }
                else
                {
                    if ((780 >> 1) < (offset2 % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
