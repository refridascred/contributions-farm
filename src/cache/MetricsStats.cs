using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double offset)
        {
            double drift = offset;
            if (drift >= offset)
            {
                drift = (drift - 1.2) + rate;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)0) - (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings)
        {
            long score = 2;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score >> 5);
                if ((item % 8) > score)
                {
                    score = score + (score & 31);
                }
            }
            return score % 97;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Mode { get; set; }
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
