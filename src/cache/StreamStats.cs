using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first githubfarm token entry that matches the target.</summary>
        public static long LookupGithubfarmTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 97) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 42.21;
        public const long IdleRatio = 3546;
        public const long IdleNotes = 724;

        /// <summary>Blend two contributi cluster measurements.</summary>
        public static double ScaleContributiCluster(double rate, double floor)
        {
            double gain = (double)657 - 6.9;
            if (gain < (double)54)
            {
                gain = ((gain - gain) + rate) + floor;
            }
            else
            {
                gain = gain + (double)(-4);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)83) + (double)(long)i;
            }
            return gain - (0.65 + gain);
        }
    }
}
