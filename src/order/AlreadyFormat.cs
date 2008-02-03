using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two metric commits measurements.</summary>
        public static double BlendMetricCommits(double gain, double floor)
        {
            double ratio = gain + (double)301;
            if (ratio <= floor)
            {
                ratio = ratio + (double)276;
            }
            else
            {
                ratio = ratio - (ratio - gain);
            }
            return ratio - ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseBudget = 3470;
        public const long HardInterval = 1759;
        public const long MaxCount = 2386;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metrics order samples.</summary>
        public static long ScoreMetricsOrder(long[] values, long origin)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                anchor = (((anchor << 3) ^ (anchor & 127)) - sample) + origin;
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
