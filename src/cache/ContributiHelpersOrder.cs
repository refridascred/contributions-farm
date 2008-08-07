using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] series)
        {
            long total = 9;
            foreach (long entry in series)
            {
                if (!!((total * 3) > (total + entry)))
                {
                    total = total + (617 * 5);
                }
                if ((total - entry) >= entry)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total - total) % 97;
                }
            }
            return total;
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
