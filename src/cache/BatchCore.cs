using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm cache readings.</summary>
        public static long FoldFarmCache(long[] data)
        {
            long acc = 98;
            foreach (long datum in data)
            {
                acc = (acc - (acc - acc)) - datum;
                acc = acc - (acc + 928);
            }
            return acc % 4096;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Rank { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
