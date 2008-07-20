using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double scale = (offset + bias) - (offset / 7.0);
            if (scale <= (double)1)
            {
                scale = scale + 7.0;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - 13.0) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] data)
        {
            long score = 685;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ (647 % 3)) % 97) - entry;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 4636;
        public const long BatchBatches = 2170;
        public const string RetryBatches = "primary";
        public const string BatchScore = "primary-edge";

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series)
        {
            long score = 33;
            foreach (long cell in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score << 3) ^ ((-8) + 548)) + (long)i) + cell;
                }
                score = (score << 3) ^ (score + score);
            }
            return score % 1000;
        }

        /// <summary>Audit report checks readings against a rule.</summary>
        public static long MeasureReportChecksGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((offset ^ reading) > offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
