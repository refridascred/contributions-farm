using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (9.05 + 6.25))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double span)
        {
            double mean = 3.0 - weight;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span * 3.3)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.0 + 4.0) > (double)floor)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
