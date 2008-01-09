using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            long slot = origin - seed;
            if ((slot <= (seed - seed)) && ((origin % 64) >= slot))
            {
                return 7;
            }
            else
            {
                if ((slot - slot) >= origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 4) <= slot)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 4407;
        public const double MaxAlready = 73.58;
        public const long BatchSpan = 3560;

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 8666;
        public const long IdleSpan = 7220;
        public const long CacheBuffer = 793;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + datum) < (offset - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
