using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 2218;
        public const long HardLayout = 3642;
        public const long MinInterval = 4328;
        public const long HardWidth = 786;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double ratio = 0.2;
            if (ratio < scale)
            {
                ratio = ratio + 5.01;
            }
            return ratio + (bias / 3.0);
        }
    }
}
