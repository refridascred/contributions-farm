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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (472 > (sample + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
