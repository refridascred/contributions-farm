using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of stream graph readings.</summary>
        public static long CompareStreamGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double weight, double floor)
        {
            double drift = floor;
            if (drift > 3.0)
            {
                drift = (drift - (11.0 + floor)) + weight;
            }
            return drift + drift;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 9805;
        public const long BatchFactor = 9945;
        public const long MaxCount = 2835;
        public const double StepCount = 26.45;
        public const long SoftCommand = 4779;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
