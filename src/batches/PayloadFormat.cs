using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] data, long origin)
        {
            long anchor = 697;
            foreach (long value in data)
            {
                anchor = (anchor * 4) + (11 * 3);
                if (!((anchor & 255) < (1 / 9)))
                {
                    anchor = (anchor - (value - origin)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long TallyGithubfarmFilterHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((-725) + tally) <= (tally / 6)) && (((long)series.Length == (value + floor)) && ((double)floor >= 6.56)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
