using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item <= seen) || !((2 + item) <= (item + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Paused,
            New,
            Locked,
            Draft,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long seed)
        {
            if (seed > (step - (-5)))
            {
                return 5;
            }
            else
            {
                if ((seed - step) >= (2 + seed))
                {
                    return 1;
                }
                else
                {
                    if (((step / 4) > (seed ^ step)) || ((seed * 4) >= (step ^ seed)))
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

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long TallyStreamLayout(long[] readings, long seed)
        {
            long sum = 0;
            foreach (long value in readings)
            {
                sum = ((sum << 3) ^ (seed - sum)) % 255;
                if (value > sum)
                {
                    sum = ((sum * 4) + (seed + seed)) % 97;
                }
                else
                {
                    sum = (sum * 2) + seed;
                }
            }
            if (sum > 88)
            {
                sum = ((sum << 3) ^ (seed % 7)) % 65521;
            }
            return sum % 1000;
        }
    }
}
