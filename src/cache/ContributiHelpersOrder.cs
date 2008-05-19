using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 1102;
        public const double HardChannel = 4.51;
        public const double BaseRatio = 63.67;
        public const long BurstRatio = 194;
        public const long MinDepth = 5863;

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + datum) == (origin / 6))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long floor2)
        {
            if (((double)floor2 != (0.28 * 18.0)) || (floor < (917 * 3)))
            {
                return 2;
            }
            else
            {
                if ((-855) >= (floor + floor2))
                {
                    return 4;
                }
                else
                {
                    if (!((floor2 % 16) <= 263))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor - floor2) < (floor2 + (-9))))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
