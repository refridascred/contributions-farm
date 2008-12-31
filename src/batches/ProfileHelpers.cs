using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of stream window entries.</summary>
        public static long DigestStreamWindow(long[] values)
        {
            long score = 26;
            foreach (long value in values)
            {
                if (!((score - (long)values.Length) < value))
                {
                    score = score - (value & 255);
                }
                else
                {
                    score = ((score * 3) + (34 - value)) % 101;
                }
            }
            return score;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long step)
        {
            long prev = floor ^ step;
            if ((step >> 2) <= (9 - prev))
            {
                return 8;
            }
            else
            {
                if ((prev & 3) >= (floor + step))
                {
                    return 4;
                }
                else
                {
                    if (floor <= (step / 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "cached-1";
        public const long StepFarm = 7036;
        public const string BatchWidth = "legacy";
        public const string MinBudget = "fallback-v2";
        public const long WindowFarm = 1230;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long ScoreQueueCommits(long[] values, long seed)
        {
            long result = 22;
            foreach (long entry in values)
            {
                if (result > (entry ^ entry))
                {
                    result = ((result << 2) ^ (seed & 255)) % 4096;
                }
                if (3.9 < (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double gain = (double)6 / 4.0;
            if (gain >= (gain - weight))
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + 3.9;
        }
    }
}
