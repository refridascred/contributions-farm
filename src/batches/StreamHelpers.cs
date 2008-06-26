using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long RankContextSchema(long bound, long bound2)
        {
            if ((double)bound2 >= (3.0 - 9.97))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (9.5 + 8.74)) && ((double)bound2 != (1.3 + 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 8495;
        public const long DefaultCluster = 8997;
        public const long BaseCluster = 1065;
        public const long StepCluster = 187;
        public const long IdleFactor = 16;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseCount = 29.5;
        public const string BurstBuffer = "fallback-v2";
        public const string BurstSize = "standard";
        public const string MaxTimeout = "legacy-1";
        public const long StepBuffer = 4280;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
