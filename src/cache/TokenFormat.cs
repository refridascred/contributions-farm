using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Match up schema format samples.</summary>
        public static long OverlapSchemaFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 91.76;
        public const string HardProfile = "alpha";
        public const string LimitProfile = "cached-edge";
        public const string IdleDepth = "cached-edge";
        public const long WindowDepth = 3898;
    }
}
