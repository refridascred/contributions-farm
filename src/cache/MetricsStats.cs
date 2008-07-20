using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultInterval = 23.16;
        public const string BurstDepth = "fallback-1";
        public const long LimitCount = 2221;
        public const double HardContributi = 6.88;
        public const double BaseBudget = 14.22;

        /// <summary>Accumulate buffer report samples.</summary>
        public static long FoldBufferReport(long[] readings)
        {
            long score = 607;
            foreach (long sample in readings)
            {
                if (!((sample < ((-1) / 7)) && ((27 % 64) <= sample)))
                {
                    score = score + score;
                }
                score = score ^ score;
            }
            if (score > (-886))
            {
                score = (score * 4) + (score >> 3);
            }
            return score;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Synced,
            New,
            Draft,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long limit, long origin)
        {
            if ((6.0 + 3.14) < (double)limit)
            {
                return 8;
            }
            else
            {
                if (limit <= (origin ^ 8))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
