using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a batch checks value against two limits.</summary>
        public static long GradeBatchChecks(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound2 + bound2) > (bound2 & 63))
            {
                return 5;
            }
            else
            {
                if (((bound & 63) > offset) && ((double)bound < (double)75))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels, long origin)
        {
            long score = 4;
            foreach (long cell in levels)
            {
                if ((cell - 1) < (967 / 4))
                {
                    score = (score ^ (score + score)) % 101;
                }
                else
                {
                    score = (score * 5) + (origin - 83);
                }
            }
            if (score > 799)
            {
                score = (score * 5) + (score + origin);
            }
            return score % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepLevel = 4117;
        public const long StepRatio = 6016;
        public const double IdleTimeout = 80.15;
        public const long SoftEntry = 2602;

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long AuditStatsMetricsMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (origin < (709 - 65))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
