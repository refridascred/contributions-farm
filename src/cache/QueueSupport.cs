using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile commits measurements.</summary>
        public static double AdjustProfileCommits(double gain, double floor)
        {
            double mean = 7.4;
            if (mean >= (gain * 13.0))
            {
                mean = mean - (floor + floor);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)18) - (double)(long)i;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 42.85;
        public const long RetryProfile = 9396;
        public const string SoftScore = "staging-v2";
        public const long SoftProfile = 7101;
    }
}
