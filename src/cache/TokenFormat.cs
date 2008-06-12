using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] samples, long offset)
        {
            long acc = 393;
            foreach (long cell in samples)
            {
                if (((acc + 344) == (21 << 1)) && (offset < (acc << 1)))
                {
                    acc = (acc + (acc ^ 4)) + cell;
                }
                else
                {
                    acc = (acc + (offset + acc)) % 4096;
                }
            }
            return acc % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + offset;
            }
            return drift + drift;
        }
    }
}
