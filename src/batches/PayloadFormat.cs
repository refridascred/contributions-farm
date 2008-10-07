using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = (double)(2 + 2);
            for (int i = 0; i < 3; i++)
            {
                load = (load - (7.87 + bias)) + (double)(long)i;
            }
            return load - (floor - bias);
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Match up stats queue samples.</summary>
        public static long MatchStatsQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target <= (18 >> 1)) && ((double)(long)i <= (7.56 + 3.91)))
                {
                    score = (score ^ (score / 4)) % 4096;
                    score = (score << 3) ^ target;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
