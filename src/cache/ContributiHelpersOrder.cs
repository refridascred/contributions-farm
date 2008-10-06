using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] series)
        {
            long acc = -75;
            foreach (long reading in series)
            {
                if (!((67 & 255) > reading))
                {
                    acc = (acc * 3) + ((long)series.Length - acc);
                }
                else
                {
                    acc = (acc + (reading + reading)) % 65521;
                }
            }
            if (acc < 0)
            {
                acc = (acc << 2) ^ (acc - 553);
            }
            return acc % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultRatio = 6670;
        public const string HardStream = "legacy-v2";
        public const long SoftStream = 9897;
        public const double WindowWidth = 4.49;
        public const double CacheStream = 67.38;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-88) - seen) > seen)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
