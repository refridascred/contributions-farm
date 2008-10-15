using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double AdjustEntryEditor(double rate, double bias)
        {
            double mean = (double)(549 * 3);
            if (mean < (rate + rate))
            {
                mean = (mean + mean) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (8.5 / 9.0)) + (double)(long)i;
            }
            return mean + (double)57;
        }

        /// <summary>Iterate the queue report series from a seed.</summary>
        public static long SeriesQueueReport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = (score ^ (score * 4)) % 4096;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a cache metric counter forward.</summary>
        public static long DeriveCacheMetric(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
