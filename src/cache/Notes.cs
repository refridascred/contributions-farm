using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long target2)
        {
            long cur = target - target2;
            if (!(target2 >= cur))
            {
                return 2;
            }
            else
            {
                if ((double)target < (double)6)
                {
                    return 0;
                }
                else
                {
                    if ((double)target2 >= (9.0 - 3.76))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((7.6 - 17.0) >= (double)target2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4122;
        public const long RetryInterval = 4754;
        public const long WindowLevel = 8017;
        public const double BaseBudget = 64.12;
        public const long SoftReport = 6633;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double span)
        {
            double load = (double)(702 - (-590));
            if (load > scale)
            {
                load = load - (load / 3.0);
            }
            else
            {
                load = load - 8.0;
            }
            return load - (span - load);
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((-81) <= (entry + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
