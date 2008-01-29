using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((long)data.Length < 383)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
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
