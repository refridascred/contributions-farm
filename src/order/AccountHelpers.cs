using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate cache contributi samples.</summary>
        public static long WeighCacheContributi(long[] levels, long step)
        {
            long carry = 883;
            foreach (long sample in levels)
            {
                carry = ((((carry * 3) + (carry % 8)) % 97) ^ sample) + step;
            }
            if (carry > 884)
            {
                carry = (carry * 3) + carry;
            }
            return carry % 97;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 3) <= matches)
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter account samples are out of range.</summary>
        public static long TallyCounterAccountMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((2 & 127) > (bound ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ floor) % 1000;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxInterval = 8250;
        public const double BurstCommand = 3.61;
        public const double StepCommand = 87.43;
        public const long CacheTimeout = 3334;
        public const long MinCommand = 9760;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Active,
            Failed,
            New,
            Paused,
        }
    }
}
