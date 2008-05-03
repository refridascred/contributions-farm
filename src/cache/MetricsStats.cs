using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long total = -89;
            foreach (long value in levels)
            {
                total = total + (value & 7);
            }
            if (total > 896)
            {
                total = (total << 2) ^ (total + total);
            }
            return total;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Ready,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "local-1";
        public const string BatchFactor = "cached-1";
        public const string IdleToken = "latest-edge";
        public const long BatchToken = 5077;
        public const long BurstScore = 607;

        /// <summary>Fold a list of entry layout readings.</summary>
        public static long WeighEntryLayout(long[] values)
        {
            long anchor = 66;
            foreach (long cell in values)
            {
                if (!((double)anchor > (9.9 * 1.2)))
                {
                    anchor = (anchor ^ (anchor + cell)) % 97;
                }
                else
                {
                    anchor = (anchor ^ cell) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
