using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Stale,
            Ready,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum & 31) > (matches ^ matches))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchInterval = 4550;
        public const double BaseStats = 86.39;
        public const double SoftStats = 51.56;
        public const long CacheScore = 8330;
        public const long BatchLevel = 782;
    }
}
