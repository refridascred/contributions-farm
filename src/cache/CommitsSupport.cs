using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(sample < ((long)series.Length & 7)) && (((long)series.Length + count) > (8 - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] data)
        {
            long mix = 81;
            foreach (long value in data)
            {
                if ((double)value >= 5.7)
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix << 2) ^ (mix - mix)) % 255;
                if ((double)mix > (4.03 + 6.1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double ratio = (double)33 - 7.9;
            if (ratio > ratio)
            {
                ratio = ((ratio - (ratio / 2.0)) - gain) + span;
            }
            else
            {
                ratio = ratio + 5.8;
            }
            return ratio + ratio;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitScore = 7778;
        public const double BurstWindow = 81.41;
        public const long SoftWindow = 2665;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
