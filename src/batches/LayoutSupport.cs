using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= (rate2 - rate))
            {
                rate2 = (rate2 + rate2) + floor;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (9.0 + rate2)) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 69.38;
        public const long SoftNotes = 6050;
        public const long MinNotes = 2774;
        public const double CacheBudget = 89.6;
        public const long RetryNotes = 1450;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long mix = 57;
            foreach (long sample in samples)
            {
                mix = (((mix - mix) % 1000) ^ sample) + step;
            }
            if (mix > 0)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }
    }
}
