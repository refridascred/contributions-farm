using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "fallback-edge";
        public const long StepCount = 3886;
        public const long IdleRoute = 8150;

        /// <summary>Derive the next stream contributi value from a seed.</summary>
        public static long RollStreamContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state != (8.0 + 3.1))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)datum < (11.0 - 2.8))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm cache values into a single score.</summary>
        public static long FoldGithubfarmCache(long[] items, long offset)
        {
            long carry = 566;
            foreach (long sample in items)
            {
                carry = (carry - (sample >> 2)) + offset;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
