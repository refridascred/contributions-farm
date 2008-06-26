using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + entry) >= (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4161;
        public const string MinSize = "staging-1";
        public const double LimitBudget = 40.96;

        /// <summary>Look up the position of a commits checks sample.</summary>
        public static long LocateCommitsChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long offset, long target)
        {
            if (((double)offset != (5.8 - 2.17)) || ((target + target) < 0))
            {
                return 7;
            }
            else
            {
                if ((9.23 - 9.0) <= (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((target < (target + offset)) && ((20.0 / 9.0) != (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
