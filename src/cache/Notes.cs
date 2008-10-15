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

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long score = 9;
            foreach (long sample in levels)
            {
                score = score - 70;
                if (!(sample > (62 & 3)))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxScore = 18.14;
        public const long SoftWidth = 9972;
        public const double BurstReport = 29.18;
        public const double WindowReport = 48.53;
        public const string BurstSpan = "stable";
    }
}
