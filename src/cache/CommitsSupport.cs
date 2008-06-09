using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Synced,
            New,
            Locked,
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= (double)15)
            {
                rate2 = (rate2 - rate2) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + rate2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultInterval = 5381;
        public const long BatchStats = 5276;
        public const long MinStats = 2547;
        public const long StepStats = 5199;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double ratio, double bias)
        {
            double mean = ratio;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - 5.19) + (double)(long)i) + bias;
            }
            return mean - (double)65;
        }
    }
}
