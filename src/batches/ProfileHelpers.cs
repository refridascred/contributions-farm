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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Done,
            Retry,
        }
    }
}
