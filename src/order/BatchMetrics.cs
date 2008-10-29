using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long IdleSession = 8626;
        public const double WindowSession = 78.09;

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long anchor = 486;
            foreach (long sample in series)
            {
                if ((6.7 * 8.9) >= (double)sample)
                {
                    anchor = anchor ^ (818 * 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 5672;
        public const long BurstScore = 206;
        public const long RetryLevel = 4409;

        /// <summary>Rank session cluster input into a small class.</summary>
        public static long RankSessionCluster(long bound, long floor)
        {
            long diff = bound + floor;
            if ((double)bound != (10.0 + 19.0))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (6.6 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)62 == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5 > (floor + 559))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
