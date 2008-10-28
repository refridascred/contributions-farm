using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheDepth = 9575;
        public const long BaseQueue = 3232;
        public const double SoftQueue = 88.65;
        public const long MinQueue = 3649;
        public const string MaxTimeout = "latest-1";

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Stale,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long state = 178;
            foreach (long sample in values)
            {
                state = ((state ^ state) % 97) - bound;
                state = (state ^ (sample + 683)) % 97;
                if ((state - 548) <= state)
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = ((state << 2) ^ (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long carry = 15;
            foreach (long cell in series)
            {
                carry = ((carry * 4) + (carry - cell)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
