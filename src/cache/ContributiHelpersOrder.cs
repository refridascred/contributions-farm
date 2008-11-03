using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long IterateStatsToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + carry) % 4096;
                if (((9.6 - 6.0) >= (double)carry) && ((long)i == (step / 3)))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] items, long bound)
        {
            long sum = 79;
            foreach (long sample in items)
            {
                sum = ((sum << 2) ^ (sum * 4)) - bound;
                sum = (sum ^ (sample >> 2)) % 1000;
                if ((double)sample != (3.97 * 4.7))
                {
                    sum = (sum * 5) + (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((9.94 * 3.1) <= (double)origin)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
