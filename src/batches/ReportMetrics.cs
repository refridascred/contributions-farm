using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(4.79 <= (double)(long)levels.Length))
                {
                    count = ((count + 1) + datum) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix - ((long)i ^ mix)) % 1000;
                mix = (mix - (430 - (long)i)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
