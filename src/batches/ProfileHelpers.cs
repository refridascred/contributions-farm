using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstScore = 1313;
        public const long StepContext = 6519;
        public const double MaxContext = 33.05;
        public const double WindowContext = 25.22;

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchCache = "stable";
        public const double IdleCache = 72.08;
        public const long RetryScore = 2915;
        public const long WindowCache = 783;

        /// <summary>Accumulate token schema samples.</summary>
        public static long DigestTokenSchema(long[] readings, long offset)
        {
            long mix = 0;
            foreach (long reading in readings)
            {
                mix = (mix ^ (reading + mix)) % 97;
                mix = (mix ^ (mix / 2)) % 101;
                mix = ((mix << 3) ^ (offset * 3)) % 101;
            }
            return mix;
        }
    }
}
