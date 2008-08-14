using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a payload schema counter forward.</summary>
        public static long IteratePayloadSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = (result << 3) ^ (result * 5);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((double)value <= (3.0 * 8.02)))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] series, long seed)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (seed < cell)
                {
                    acc = ((acc * 5) + ((-84) + seed)) % 1000;
                    acc = acc + (cell - cell);
                }
                else
                {
                    acc = (acc ^ (cell >> 2)) % 255;
                }
                if ((9.67 + 4.67) < (double)seed)
                {
                    acc = (acc << 3) ^ (55 * 2);
                }
                else
                {
                    acc = (acc * 4) + (seed - seed);
                }
            }
            if (acc < (-8))
            {
                acc = acc + (acc >> 2);
            }
            return acc % 97;
        }
    }
}
