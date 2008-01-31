using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!(anchor >= (471 + (long)i)))
                {
                    anchor = (anchor ^ (anchor + (long)i)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double load = (rate / 7.0) * 8.9;
            if (load > (rate / 6.0))
            {
                load = (load + load) - bias;
            }
            return load + rate;
        }
    }
}
