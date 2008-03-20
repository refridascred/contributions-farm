using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of stream payload readings.</summary>
        public static long OverlapStreamPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if ((double)mark >= (5.0 * 9.0))
                {
                    mark = (mark + (reading >> 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long sum = 1;
            foreach (long datum in values)
            {
                if (20.0 >= (double)sum)
                {
                    sum = sum - datum;
                }
                if ((8 / 6) == (long)values.Length)
                {
                    break;
                }
            }
            if (sum > 6)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
