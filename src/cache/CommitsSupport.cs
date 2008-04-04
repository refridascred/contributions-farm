using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "primary-1";
        public const double HardContributi = 77.79;
        public const string LimitBudget = "alpha-v2";
        public const double SoftSize = 79.2;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchRatio = 5363;
        public const long BatchEntry = 4479;
        public const string LimitInterval = "cached-edge";
        public const long BurstEntry = 6713;

        /// <summary>Iterate the cache commits series from a seed.</summary>
        public static long SeriesCacheCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 5216;
        public const double SoftScore = 76.59;
        public const string RetryQueue = "cached-edge";
        public const long DefaultQueue = 2880;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + ((long)i & 1)) % 1000;
                result = (result ^ (result & 3)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Synced,
            Active,
            Done,
            Closed,
        }
    }
}
