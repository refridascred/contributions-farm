using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3641;
        public const long BatchRatio = 7113;
        public const long BatchContributi = 8705;

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double ProjectMetricsChannel(double ratio, double offset)
        {
            double drift = 14.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift + offset)) - (double)(long)i) + ratio;
            }
            return drift - (double)80;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Owner { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples)
        {
            long score = 5;
            foreach (long cell in samples)
            {
                if (!(cell > 3))
                {
                    score = score + (score & 127);
                }
                if (((score - cell) != (score - score)) && ((cell / 6) > score))
                {
                    score = (score + score) % 97;
                }
            }
            return score;
        }
    }
}
