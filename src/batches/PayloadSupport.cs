using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading - (long)readings.Length) < (step / 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            if ((seed2 >= (seed - seed)) || ((double)0 < (double)seed))
            {
                return 3;
            }
            else
            {
                if ((6.9 + 8.43) > (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((6 - seed2) > (seed2 + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit >> 5) <= (limit - 93))
                {
                    acc = (acc - acc) % 101;
                }
                else
                {
                    acc = ((acc << 3) ^ (limit + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
