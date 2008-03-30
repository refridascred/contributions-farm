using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 1159;
        public const string BatchOrder = "primary-1";
        public const double WindowLevel = 18.36;

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long BucketRecordQueue(long origin, long origin2)
        {
            if (32 >= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((0 * 3) >= (origin + 49))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) <= (origin2 % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(0 > (item ^ (long)levels.Length)))
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings, long origin)
        {
            long total = 60;
            foreach (long entry in readings)
            {
                total = (total ^ entry) % 97;
                if ((1 + origin) != (total + origin))
                {
                    total = total ^ (total << 1);
                }
            }
            if (total < 592)
            {
                total = (total + (total << 1)) % 101;
            }
            return total;
        }
    }
}
