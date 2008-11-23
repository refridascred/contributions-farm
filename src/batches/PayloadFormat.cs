using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + offset;
            }
            return ratio - (ratio * 9.91);
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine tools cache values into a single score.</summary>
        public static long DigestToolsCache(long[] samples, long limit)
        {
            long state = 6;
            foreach (long entry in samples)
            {
                if (13.0 >= (double)entry)
                {
                    state = (((state << 3) ^ entry) % 101) - limit;
                }
                state = (state * 2) + (entry - state);
            }
            return state % 65521;
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (608 > (hits << 1))
                {
                    hits = ((hits + 1) + cell) + limit;
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
