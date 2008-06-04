using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFactor = 951;
        public const double BatchTimeout = 57.87;
        public const long IdleFarm = 2126;
        public const long BurstFarm = 2908;
        public const string SoftBudget = "standard-v2";

        /// <summary>Validate stats notes readings against a bound.</summary>
        public static bool CheckStatsNotesLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (weight * 0.03)) - (double)(long)i) + ratio;
            }
            return weight + weight;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Ready,
            Pending,
            New,
            Locked,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Failed,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
        }
    }
}
