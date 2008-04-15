using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (double)floor)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 7;
            foreach (long reading in data)
            {
                if ((reading << 1) > (acc - acc))
                {
                    acc = (acc ^ (acc + reading)) % 101;
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc & 31)) % 65521;
                }
                if (!((reading - acc) <= (reading & 1)))
                {
                    acc = acc - (6 >> 1);
                }
                else
                {
                    acc = acc + (2 ^ reading);
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (49 - cell)))
                {
                    sum = ((sum * 3) + (cell >> 4)) % 101;
                    sum = ((sum * 4) + cell) % 101;
                }
                else
                {
                    sum = (sum * 2) + (sum >> 3);
                }
                if ((((long)series.Length * 5) == (cell << 3)) || ((sum % 2) >= 253))
                {
                    sum = (sum * 4) + sum;
                }
            }
            return sum;
        }
    }
}
