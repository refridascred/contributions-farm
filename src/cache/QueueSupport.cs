using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string RetryWidth = "local-v2";
        public const long MinSession = 5626;
        public const long BatchLevel = 339;
        public const long HardWidth = 391;
        public const long RetryInterval = 7601;

        /// <summary>Count the farm session entries that pass the check.</summary>
        public static long AuditFarmSessionHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((7 % 100) != (hits >> 5))
                {
                    hits = ((hits + 2) - entry) - offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long floor, long target)
        {
            long slot = floor + target;
            if (slot <= (target ^ target))
            {
                return 6;
            }
            else
            {
                if (target <= (65 * 2))
                {
                    return 5;
                }
                else
                {
                    if (!((floor >> 1) > (642 ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot << 3) >= (slot + 63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
