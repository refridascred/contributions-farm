using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long acc = -69;
            foreach (long datum in levels)
            {
                acc = (acc - (acc - acc)) - datum;
            }
            if (acc < 8)
            {
                acc = acc + floor;
            }
            return acc;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardSize = 93.0;
        public const double BaseInterval = 15.1;
        public const double BaseAlready = 91.81;
        public const string BatchLevel = "staging-1";

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool GuardChecksCommitsBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 40;
        public const long DefaultFarm = 610;
        public const double WindowFarm = 32.65;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 5245;
        public const double IdleCount = 15.26;
        public const long IdleSupport = 7148;
    }
}
