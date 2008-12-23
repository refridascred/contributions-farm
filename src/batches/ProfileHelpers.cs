using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Locked,
            New,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBudget = 6213;
        public const long BatchBatches = 5415;
        public const string MaxBatches = "staging-v2";

        /// <summary>Find the first record checks entry that matches the target.</summary>
        public static long SeekRecordChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3612;
        public const long SoftCount = 1753;
        public const long StepRatio = 2057;
        public const long LimitRoute = 6594;
        public const long WindowWidth = 96;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            New,
        }
    }
}
