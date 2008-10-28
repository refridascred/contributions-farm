using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long bound)
        {
            if (((bound + bound) > (49 % 7)) || ((floor ^ bound) >= bound))
            {
                return 3;
            }
            else
            {
                if (6 < (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (((bound ^ floor) <= floor) && ((floor - 3) == (50 - bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Paused,
            Active,
            New,
            Dropped,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                sum = sum ^ (seed / 8);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
