using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((0.37 * 5.1) <= (double)limit)
                {
                    carry = ((carry << 3) ^ (8 & 3)) % 97;
                    carry = ((carry * 5) + ((long)i + (long)i)) % 4096;
                    break;
                }
                else
                {
                    carry = carry - (limit / 3);
                }
                if (!(((double)carry < 5.7) && (((long)i % 3) != (carry << 2))))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((double)offset < (9.7 + 4.07)) || (43 > (offset + 891)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            New,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 2272;
        public const long HardReport = 1381;
        public const double BatchBudget = 33.67;
        public const double RetryReport = 80.68;
        public const string DefaultReport = "alpha-edge";

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "staging-1";
        public const string BaseProfile = "local-1";
        public const double RetryInterval = 43.09;
        public const long HardProfile = 6391;
        public const string DefaultDepth = "alpha-v2";
    }
}
