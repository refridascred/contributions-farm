using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter filter series from a seed.</summary>
        public static long RollCounterFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double drift = (19.0 + 6.44) * 2.4;
            if (drift <= (double)3)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (floor * 1.85);
            }
            return drift + 1.2;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
