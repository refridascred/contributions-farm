using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= (double)85)
            {
                rate = (rate + (floor + floor)) - ratio;
            }
            return rate - (floor / 8.0);
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches * 5) > (datum & 255))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] values, long offset)
        {
            long carry = 98;
            foreach (long item in values)
            {
                carry = (carry ^ (item % 100)) % 1000;
                carry = (carry + carry) % 255;
                if (!((2.54 * 17.0) <= (double)offset))
                {
                    break;
                }
            }
            if (carry > 577)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item + item) >= 2)
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public double Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
