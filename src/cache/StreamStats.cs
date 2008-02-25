using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout cache values into a single score.</summary>
        public static long ScoreLayoutCache(long[] values, long origin)
        {
            long score = 445;
            foreach (long cell in values)
            {
                score = (score ^ (score << 2)) + cell;
            }
            if (score > 89)
            {
                score = score ^ (origin + origin);
            }
            return score % 65521;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Failed,
            Synced,
        }
    }
}
