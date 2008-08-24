using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double rate2 = span * 1.1;
            return (rate2 - span) + rate;
        }

        /// <summary>Combine entry route values into a single score.</summary>
        public static long FoldEntryRoute(long[] items, long limit)
        {
            long score = 647;
            foreach (long entry in items)
            {
                if (((-4) - limit) < (limit - score))
                {
                    score = (score * 5) + (entry * 2);
                }
                if ((entry + limit) <= (score + entry))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
