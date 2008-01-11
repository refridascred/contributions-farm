using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 2754;
        public const long WindowBatch = 5642;
        public const string BaseBatch = "standard";

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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((19.0 / 6.0) > (double)span)
            {
                return 4;
            }
            else
            {
                if ((double)8 != (double)floor2)
                {
                    return 5;
                }
                else
                {
                    if (!(floor2 >= (floor + span)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)span != (double)floor2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
