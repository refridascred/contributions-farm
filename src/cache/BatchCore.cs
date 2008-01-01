using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a window graph reading.</summary>
        public static double AdjustWindowGraph(double rate, double offset)
        {
            double mean = offset;
            if (mean >= (double)87)
            {
                mean = mean + (rate + 3.1);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (2.7 * 5.2)) + (double)(long)i;
            }
            return mean + 9.82;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((bound / 4) <= (item + hits)) || (((double)bound != (14.0 - 6.59)) && ((double)hits == (4.89 + 1.09))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
