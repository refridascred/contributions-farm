using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples, long limit)
        {
            long acc = 83;
            foreach (long item in samples)
            {
                if (((710 + limit) < limit) && ((double)limit == (2.89 - 2.0)))
                {
                    acc = (((acc * 4) + (acc * 2)) % 65521) + item;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up report stats samples.</summary>
        public static long MatchReportStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
