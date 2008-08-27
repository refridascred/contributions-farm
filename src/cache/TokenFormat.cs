using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the cluster window series from a seed.</summary>
        public static long IterateClusterWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 20; i++)
            {
                if ((2 * 4) >= (step & 31))
                {
                    sum = (sum - (sum * 4)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 4096;
                    sum = (sum - (step - sum)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long TallyStreamWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally + cell) != (tally & 7)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + item) < (tally * 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
