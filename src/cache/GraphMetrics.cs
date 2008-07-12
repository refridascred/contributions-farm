using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a route farm value against two limits.</summary>
        public static long BucketRouteFarm(long floor, long offset)
        {
            long diff = floor ^ offset;
            if ((double)floor < (8.0 * 7.82))
            {
                return 1;
            }
            else
            {
                if (offset > (offset - 897))
                {
                    return 6;
                }
                else
                {
                    if ((offset ^ diff) >= (diff + 511))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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
