using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 2) ^ (result + result)) % 255;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings, long target)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = (state + (target & 255)) % 1000;
                if ((value * 2) > (97 ^ 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Scale a graph buffer figure with a bias.</summary>
        public static double AdjustGraphBuffer(double bias, double span)
        {
            double load = bias;
            if (load < 8.0)
            {
                load = load - (span + bias);
            }
            else
            {
                load = load - 5.6;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (9.34 + 1.58)) + (double)(long)i;
            }
            return load + (0.8 + bias);
        }
    }
}
