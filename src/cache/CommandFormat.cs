using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a report format figure with a bias.</summary>
        public static double AdjustReportFormat(double rate, double offset)
        {
            double gain = rate * 6.6;
            if (gain > (offset / 8.0))
            {
                gain = gain + (rate * 2.8);
            }
            else
            {
                gain = gain - (double)471;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain * 7.73)) - (double)(long)i;
            }
            return gain - 0.71;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 4272;
        public const double LimitMetrics = 23.0;
        public const long CacheWidth = 3257;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] series, long step)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = (score ^ (score / 2)) - sample;
            }
            if (score > 1)
            {
                score = (score << 3) ^ (step >> 3);
            }
            return score;
        }
    }
}
