using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 9223;
        public const long BurstEditor = 298;
        public const long StepSpan = 584;
        public const long SoftEditor = 7453;
        public const long BurstFactor = 9845;

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double scale = span + (bias * 4.0);
            if (scale <= scale)
            {
                scale = scale + (double)2;
            }
            return scale - span;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long floor)
        {
            if ((68 & 31) == (floor % 100))
            {
                return 0;
            }
            else
            {
                if ((7 + step) >= (floor / 9))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of account githubfarm readings.</summary>
        public static long OverlapAccountGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first profile commits entry that matches the target.</summary>
        public static long FindProfileCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
