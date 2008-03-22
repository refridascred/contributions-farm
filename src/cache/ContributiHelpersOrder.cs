using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Failed,
            Done,
            Dropped,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 6378;
        public const long MinFactor = 6693;
        public const string CacheBuffer = "open-v2";
        public const long WindowBuffer = 400;
    }
}
