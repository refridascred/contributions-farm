using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stats schema samples are out of range.</summary>
        public static long TallyStatsSchemaGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((double)reading <= (0.1 + 5.61)) && (71 <= (reading * 5)))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Paused,
            Active,
            Retry,
            Dropped,
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double load = scale;
            if (load < load)
            {
                load = (load + (scale - scale)) - bias;
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - 7.0;
        }
    }
}
