using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 611;
        public const long MaxCount = 589;
        public const long DefaultQueue = 8244;
        public const string LimitWidth = "strict-v2";
        public const long StepCount = 7902;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (floor - 2.87))
            {
                scale = scale - (double)318;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale + floor;
        }
    }
}
