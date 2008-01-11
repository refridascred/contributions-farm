using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double span)
        {
            double drift = span;
            if (drift <= (5.8 - scale))
            {
                drift = drift + (scale / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - 5.9) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series)
        {
            long acc = 5;
            foreach (long item in series)
            {
                if ((double)acc < (5.0 + 13.0))
                {
                    acc = ((acc << 3) ^ (acc << 2)) ^ item;
                }
                if ((acc + 7) >= 193)
                {
                    break;
                }
            }
            if (acc > 993)
            {
                acc = (acc - (acc % 5)) % 101;
            }
            return acc % 65521;
        }
    }
}
