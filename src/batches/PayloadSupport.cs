using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxDepth = 8949;
        public const string IdleWidth = "cached-1";
        public const double RetryTimeout = 66.44;
        public const double HardAlready = 98.83;
        public const long BurstDepth = 3960;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((target & 3) != (target - 388)) && ((count ^ count) == (target >> 1)))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long origin, long target)
        {
            if ((double)target <= (8.5 / 3.0))
            {
                return 4;
            }
            else
            {
                if ((target & 3) >= (origin + 16))
                {
                    return 0;
                }
                else
                {
                    if (origin > (origin + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (origin << 2))
                        {
                            return 6;
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
}
