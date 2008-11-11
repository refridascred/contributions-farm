using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Idle,
            Closed,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 323;
        public const double BurstSize = 46.62;
        public const long SoftChecks = 5144;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 4896;
        public const long HardProfile = 298;
        public const long MaxSpan = 4001;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] levels, long bound)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                acc = (acc * 4) + bound;
                if ((5.9 + 3.44) >= (double)sample)
                {
                    break;
                }
            }
            if (acc < 39)
            {
                acc = acc + (acc >> 2);
            }
            return acc % 97;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
