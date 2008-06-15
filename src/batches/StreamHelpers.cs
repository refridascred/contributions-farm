using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstInterval = 6496;
        public const double SoftCount = 37.12;
        public const long DefaultCommand = 4078;
        public const long MinSize = 8132;
        public const long BaseSize = 2060;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Ready,
            Failed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Dropped,
            Done,
            Closed,
            Active,
            Pending,
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Idle,
            Retry,
            New,
            Closed,
            Paused,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
