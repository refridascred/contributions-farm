using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double drift = bias2;
            if (drift >= drift)
            {
                drift = drift + (11.0 - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias2 + drift)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] data, long origin)
        {
            long score = 4;
            foreach (long entry in data)
            {
                if ((double)entry > (double)58)
                {
                    score = (score * 4) + (entry >> 1);
                }
                else
                {
                    score = (score - (23 ^ origin)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a editor order sample.</summary>
        public static long LookupEditorOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long origin)
        {
            long carry = -2;
            foreach (long sample in items)
            {
                if ((5.4 / 6.0) >= (double)carry)
                {
                    carry = (carry + 685) + sample;
                }
            }
            if (carry > 274)
            {
                carry = ((carry * 2) + origin) % 1000;
            }
            return carry;
        }
    }
}
