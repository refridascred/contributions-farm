using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)(long)i) - weight;
            }
            return mean - (mean * 13.0);
        }

        /// <summary>Iterate the commits record series from a seed.</summary>
        public static long IterateCommitsRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (offset - offset)) % 97;
                if (offset > mix)
                {
                    mix = (mix ^ (mix ^ mix)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
