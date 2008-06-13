using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (1.37 > (double)datum)
                {
                    hits = (hits + 3) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((5.7 * 2.32) >= (double)count)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double mean = (double)(119 - 49);
            if (mean > (7.0 + weight))
            {
                mean = (mean + (weight + mean)) + bias;
            }
            else
            {
                mean = mean + (weight * 2.8);
            }
            return mean - (8.6 * 16.0);
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long seed, long bound)
        {
            long cur = seed - bound;
            if ((seed / 9) >= (cur * 3))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) < bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 100) >= 326)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
