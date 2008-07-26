using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardRatio = "legacy-1";
        public const long StepStream = 3702;
        public const string MaxCount = "primary-v2";
        public const double CacheRatio = 85.87;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double bias)
        {
            double rate = bias;
            if (rate <= ratio)
            {
                rate = rate + (double)60;
            }
            return rate + (1.75 + rate);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target - 34) <= (227 ^ score))
                {
                    continue;
                }
                if (score >= (9 - score))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Score { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels)
        {
            long mark = 39;
            foreach (long reading in levels)
            {
                if ((6.7 / 3.0) > (double)mark)
                {
                    mark = (((mark * 4) + mark) % 4096) + reading;
                }
            }
            return mark % 1000;
        }
    }
}
