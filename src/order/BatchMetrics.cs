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

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                acc = (acc ^ (acc - 74)) % 1000;
                if (((3.2 * 0.42) <= (double)acc) || (8.0 > (double)datum))
                {
                    acc = (acc - (datum % 16)) % 1000;
                }
                else
                {
                    acc = (acc ^ (datum + datum)) % 101;
                }
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 65521;
            }
            return acc % 1000;
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
