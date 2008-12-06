using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Queued,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next window route value.</summary>
        public static double ProjectWindowRoute(double weight, double floor)
        {
            double ratio = weight / 6.0;
            return ratio + floor;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            Locked,
        }
    }
}
