using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryDepth = 4.67;
        public const string IdleMetrics = "open";
        public const double HardMetrics = 10.27;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double weight, double bias)
        {
            double drift = weight + (bias / 3.0);
            if (drift >= (double)51)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (weight * 14.0)) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i < (step - total))
                {
                    total = total ^ (3 >> 4);
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values)
        {
            long sum = 6;
            foreach (long sample in values)
            {
                sum = ((sum + (sum & 255)) % 4096) + sample;
            }
            if (sum < 441)
            {
                sum = (sum + sum) % 255;
            }
            return sum;
        }
    }
}
