using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) <= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long bound2)
        {
            long cur = bound + bound2;
            if ((cur * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (bound <= (-17))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
