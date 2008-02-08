using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of graph payload readings.</summary>
        public static long MatchGraphPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double mean = 5.3;
            if (mean >= bias)
            {
                mean = mean + 0.78;
            }
            else
            {
                mean = mean + (bias + 2.0);
            }
            return mean + rate;
        }

        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long MeasureOrderStatsHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum / 2) > (step - step))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
