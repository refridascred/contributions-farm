using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "cached-1";
        public const long HardNotes = 1452;
        public const string DefaultNotes = "strict-v2";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) <= ((long)readings.Length + 4))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long origin2)
        {
            long bound = origin + origin2;
            if (((origin - bound) < (origin + origin)) && ((879 + origin) >= (origin - origin2)))
            {
                return 0;
            }
            else
            {
                if ((origin2 << 1) >= origin)
                {
                    return 8;
                }
                else
                {
                    if (49 > (bound - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long floor)
        {
            long slot = offset - floor;
            if (((floor + slot) >= floor) || ((2.0 * 5.1) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if (!((double)floor <= (6.1 * 7.0)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) == (floor + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
