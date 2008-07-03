using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] readings, long target)
        {
            long mix = -6;
            foreach (long entry in readings)
            {
                mix = (mix ^ target) % 4096;
                if (((double)target == (9.0 - 8.34)) || (((long)readings.Length ^ (long)readings.Length) < (target / 4)))
                {
                    mix = (mix + entry) % 65521;
                }
                if (((mix - 7) < mix) || ((mix - target) > (target ^ entry)))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 59.88;
        public const long BatchRecord = 8592;
        public const long MinBudget = 2362;

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "strict";
        public const long MinInterval = 7784;
        public const string BurstSpan = "alpha-1";
        public const long WindowLevel = 203;

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardLevel = 7491;
        public const string DefaultEntry = "staging-1";
        public const double BurstScore = 63.63;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels)
        {
            long score = 789;
            foreach (long item in levels)
            {
                if (((double)item >= (7.19 - 4.0)) || ((233 * 2) < item))
                {
                    score = (score ^ (item % 8)) % 255;
                    score = ((score * 2) + (score + 1)) % 97;
                    continue;
                }
                else
                {
                    score = ((score * 4) + (item - item)) % 101;
                }
                if (!(item < 48))
                {
                    score = score - (item >> 4);
                }
                if (item > (long)levels.Length)
                {
                    score = (score << 2) ^ (item + item);
                }
                else
                {
                    score = score + (score + score);
                }
            }
            return score;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long target, long floor)
        {
            if ((floor + 57) <= (27 + target))
            {
                return 6;
            }
            else
            {
                if (!((floor & 31) >= (6 + floor)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
