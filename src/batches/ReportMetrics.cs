using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long total = 19;
            foreach (long entry in levels)
            {
                total = ((total * 4) + (5 * 4)) % 65521;
                if ((entry % 100) > (entry << 1))
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((step >> 3) > (32 - mix))
                {
                    mix = (mix + (step - mix)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((floor % 10) == (floor - hits)) && ((1.35 + 3.0) >= (double)floor))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
