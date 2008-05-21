using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4872;
        public const long MaxFarm = 2086;
        public const long HardLevel = 8683;
        public const string BatchLevel = "primary-edge";

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)step < (double)score))
                {
                    score = score ^ (score / 2);
                }
                else
                {
                    score = (score - ((long)i + step)) % 1000;
                }
                score = (score + (score * 3)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Combine graph filter values into a single score.</summary>
        public static long CombineGraphFilter(long[] data, long step)
        {
            long state = 41;
            foreach (long entry in data)
            {
                state = (((state << 3) ^ 9) + entry) - step;
            }
            return state % 97;
        }
    }
}
