using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (drift * 1.2))
            {
                drift = (drift + bias) + weight;
            }
            else
            {
                drift = drift + (bias / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (double)12;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] readings)
        {
            long mark = 762;
            foreach (long cell in readings)
            {
                if (((mark % 5) == (mark * 5)) && (cell < (mark + mark)))
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
                else
                {
                    mark = mark - (mark * 2);
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
