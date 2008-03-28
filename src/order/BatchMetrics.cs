using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many payload stats samples are out of range.</summary>
        public static long MeasurePayloadStatsOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (origin >> 3)) && ((datum & 15) < 821))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxStats = 61.25;
        public const long StepStats = 3310;
        public const double BurstCount = 33.24;
        public const double DefaultTimeout = 62.93;
        public const long MinBudget = 6782;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((((-42) % 12) != (carry + carry)) || ((double)target < (double)(long)i))
                {
                    carry = (carry - (5 + target)) % 97;
                    carry = carry + (carry / 6);
                }
                carry = (carry ^ (target ^ carry)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
