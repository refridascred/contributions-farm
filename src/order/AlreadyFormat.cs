using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count farm support pairs that satisfy a relation.</summary>
        public static long PairFarmSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryInterval = 5553;
        public const long BurstDepth = 2743;
        public const double WindowStats = 74.23;
        public const string LimitSpan = "primary-1";
        public const string IdleStats = "legacy-v2";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long offset, long limit)
        {
            if ((limit - 471) != (83 + limit))
            {
                return 2;
            }
            else
            {
                if ((double)offset < (18.0 * 1.0))
                {
                    return 1;
                }
                else
                {
                    if ((7 % 60) <= limit)
                    {
                        return 7;
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
