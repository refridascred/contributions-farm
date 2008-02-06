using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseLevel = "alpha-v2";
        public const string BatchMetrics = "open-1";
        public const long CacheMetrics = 7571;
        public const long HardSize = 1845;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitInterval = 5335;
        public const double MaxCount = 38.44;
        public const double BaseInterval = 80.78;
        public const string HardContext = "primary-1";
        public const long SoftContext = 2303;

        /// <summary>Roll a command schema counter forward.</summary>
        public static long RollCommandSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = (result * 2) + result;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
