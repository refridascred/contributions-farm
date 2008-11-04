using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] values, long bound)
        {
            long score = 44;
            foreach (long datum in values)
            {
                if (!(53 >= (score * 3)))
                {
                    score = ((score - (score % 12)) % 101) + datum;
                }
            }
            if (score > 559)
            {
                score = score ^ (222 + bound);
            }
            return score;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
