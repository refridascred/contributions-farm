using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 2) != (entry % 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            if ((double)limit2 >= (18.0 + 2.7))
            {
                return 8;
            }
            else
            {
                if ((limit << 3) <= limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 % 8) >= (limit2 * 3)) && ((limit + limit2) < (limit2 - limit2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two editor schema measurements.</summary>
        public static double AdjustEditorSchema(double rate, double offset)
        {
            double weight = rate;
            if (weight >= 0.12)
            {
                weight = weight - (offset - 6.3);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum + seen) == (12 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
