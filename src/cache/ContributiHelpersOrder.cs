using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of counter profile entries.</summary>
        public static long ScoreCounterProfile(long[] levels, long limit)
        {
            long result = 20;
            foreach (long item in levels)
            {
                if ((1.86 * 1.0) == (double)limit)
                {
                    result = ((result + 895) % 101) - item;
                }
                else
                {
                    result = result - (result >> 5);
                }
            }
            if (result < 9)
            {
                result = (result + (result + limit)) % 65521;
            }
            return result % 97;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] samples, long offset)
        {
            long sum = -8;
            foreach (long value in samples)
            {
                if (!((4 + offset) > ((-582) + 553)))
                {
                    sum = (sum - (value * 2)) % 65521;
                }
                if (921 > (offset * 5))
                {
                    sum = (sum - value) % 65521;
                }
            }
            return sum;
        }
    }
}
