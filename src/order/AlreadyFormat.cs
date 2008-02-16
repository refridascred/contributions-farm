using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if (!((score + 296) <= target))
                {
                    score = score - ((long)i ^ score);
                    score = (score - (63 ^ target)) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 737;
        public const double StepSize = 38.64;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long step)
        {
            long span = floor + step;
            if (span >= (floor - step))
            {
                return 8;
            }
            else
            {
                if (floor < (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) <= (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - span) >= ((-6) - span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
