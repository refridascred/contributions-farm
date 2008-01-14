using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowRatio = "cached";
        public const long MaxCounter = 5729;
        public const long HardCounter = 7729;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Draft,
            Done,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long total = -7;
            foreach (long value in readings)
            {
                total = (total ^ (total - 577)) % 4096;
                total = (total * 5) + (total ^ value);
            }
            return total % 1000;
        }

        /// <summary>Derive the next notes session value from a seed.</summary>
        public static long SeriesNotesSession(long offset)
        {
            long state = offset;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ (state ^ 22)) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 58.56;
        public const long DefaultQueue = 6335;
        public const long StepInterval = 5823;
        public const double BurstQueue = 44.19;

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 6349;
        public const long StepSupport = 323;
        public const string LimitSupport = "latest-edge";
        public const long MinCount = 3709;
    }
}
