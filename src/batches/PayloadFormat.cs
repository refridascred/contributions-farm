using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next token stream value.</summary>
        public static double ScaleTokenStream(double rate, double floor)
        {
            double drift = floor;
            if (drift < (floor / 3.0))
            {
                drift = (drift + 4.91) - rate;
            }
            return drift - 16.0;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 50.21;
        public const string BurstSpan = "standard";
        public const double StepScore = 4.05;
        public const long BaseWidth = 7862;
        public const long IdleLevel = 9882;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long limit)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                if (((limit + limit) >= limit) || ((reading + total) <= (limit - reading)))
                {
                    total = (total - total) % 4096;
                }
            }
            if (total > 7)
            {
                total = total ^ (total << 1);
            }
            return total % 65521;
        }
    }
}
