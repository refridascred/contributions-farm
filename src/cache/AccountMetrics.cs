using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings, long target)
        {
            long state = 24;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state + (target - (long)i)) % 255;
                }
                if ((value >= ((-768) << 3)) && (1 < value))
                {
                    state = (state ^ (target << 3)) % 65521;
                }
            }
            if (state < (-34))
            {
                state = (state * 3) + (-85);
            }
            return state % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "alpha-v2";
        public const long BaseNotes = 5967;
        public const long MinNotes = 8392;
        public const long DefaultNotes = 7610;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value ^ matches) >= (1 % 60)) && ((value % 64) >= (matches / 6)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}
