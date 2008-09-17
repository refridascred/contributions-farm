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

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] series, long seed)
        {
            long result = 81;
            foreach (long item in series)
            {
                if ((result - item) < item)
                {
                    continue;
                }
                result = ((result << 3) ^ (seed % 8)) % 101;
                result = result ^ (96 - (-43));
            }
            return result;
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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((18.0 - 0.3) >= (double)hits)
                {
                    hits = ((hits + 2) ^ cell) + target;
                }
            }
            return hits;
        }

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
