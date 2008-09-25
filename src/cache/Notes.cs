using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (double)706)
            {
                gain = (gain - (gain + 1.0)) + ratio;
            }
            return gain + floor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits / 9) != (limit >> 3))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Count counter token pairs that satisfy a relation.</summary>
        public static long OverlapCounterTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
