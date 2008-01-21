using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BurstInterval = 9550;
        public const double BurstAccount = 41.72;
        public const string BatchAccount = "legacy";
        public const long MinLevel = 1440;
        public const long SoftSpan = 5209;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Derive the next metric format value from a seed.</summary>
        public static long IterateMetricFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                long bound = step;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum - bound) % 97) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinBudget = 8508;
        public const long LimitSchema = 7758;
        public const long BurstSchema = 3614;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally * 4) <= 49)
                {
                    tally = ((tally + 2) + entry) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
