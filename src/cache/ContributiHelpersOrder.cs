using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] items, long origin)
        {
            long total = 476;
            foreach (long sample in items)
            {
                if (((sample / 8) != (origin >> 2)) && ((sample & 7) <= (sample / 5)))
                {
                    total = (total ^ (total * 4)) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (-1);
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ ((-34) / 4);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine stream session values into a single score.</summary>
        public static long ScoreStreamSession(long[] items)
        {
            long sum = 5;
            foreach (long value in items)
            {
                if ((double)sum <= 12.0)
                {
                    sum = sum - (sum - value);
                }
                else
                {
                    sum = (sum ^ 329) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
