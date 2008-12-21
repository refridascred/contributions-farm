using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultLevel = 40.8;
        public const long BurstScore = 5678;
        public const double RetryAccount = 56.08;
        public const long StepLevel = 4717;

        /// <summary>Digest a series of cluster farm entries.</summary>
        public static long TallyClusterFarm(long[] series)
        {
            long acc = 2;
            foreach (long reading in series)
            {
                if (((reading ^ reading) == (reading * 4)) || ((reading & 3) != (long)series.Length))
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc > 773)
            {
                acc = acc - (47 ^ 53);
            }
            return acc % 97;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
