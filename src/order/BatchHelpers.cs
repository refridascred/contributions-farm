using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank cache report input into a small class.</summary>
        public static long RankCacheReport(long limit, long step)
        {
            long slot = limit ^ step;
            if (!((double)limit == (0.1 + 4.7)))
            {
                return 8;
            }
            else
            {
                if (limit < slot)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double offset)
        {
            double rate = bias;
            if (rate < offset)
            {
                rate = rate - 3.7;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (offset + bias)) + (double)(long)i;
            }
            return rate - (rate / 9.0);
        }
    }
}
