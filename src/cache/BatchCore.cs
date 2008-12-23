using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1568;
        public const double BurstFactor = 86.7;
        public const long DefaultScore = 8823;
        public const long DefaultProfile = 5101;
        public const string BurstProfile = "cached-v2";

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Stale,
            Done,
            Draft,
        }
    }
}
