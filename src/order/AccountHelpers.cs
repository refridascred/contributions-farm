using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((1 - datum) > (step + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of order farm readings.</summary>
        public static long PairOrderFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((2.0 - 3.2) < (12.0 / 7.0)) && ((state - floor) <= (state * 4)))
                {
                    state = (state ^ (floor + state)) % 101;
                    state = (state * 2) + (floor << 3);
                }
                state = state ^ floor;
                state = (state << 2) ^ (floor & 1);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item - item) == (item + item))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
