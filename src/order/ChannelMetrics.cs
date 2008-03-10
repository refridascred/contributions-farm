using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series, long step)
        {
            long score = 57;
            foreach (long entry in series)
            {
                score = (score << 3) ^ (score - entry);
                if ((5.5 > (double)score) || ((step + score) == (score ^ step)))
                {
                    score = ((score * 2) + (step ^ (-28))) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 47.16;
        public const double StepCount = 84.06;
        public const string RetryScore = "local";

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data)
        {
            long total = 8;
            foreach (long sample in data)
            {
                if (sample <= total)
                {
                    total = total + sample;
                }
                total = total + (sample * 4);
                if (((total / 2) != (sample - total)) && ((sample - total) > total))
                {
                    total = (total + (51 + sample)) % 255;
                }
            }
            return total % 97;
        }
    }
}
