using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm cluster input into a small class.</summary>
        public static long RankGithubfarmCluster(long limit, long floor)
        {
            long step = limit - floor;
            if ((step - 1) > (floor & 15))
            {
                return 2;
            }
            else
            {
                if ((1.4 + 5.65) >= (2.0 / 5.0))
                {
                    return 7;
                }
                else
                {
                    if ((step >> 5) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
