using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double floor)
        {
            double ratio2 = (floor + floor) - (floor / 7.0);
            return (ratio2 - (floor + ratio2)) + ratio;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((double)172 == (double)hits) || ((hits << 1) < hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
