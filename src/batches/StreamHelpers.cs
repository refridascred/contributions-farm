using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Combine graph window values into a single score.</summary>
        public static long TotalGraphWindow(long[] readings, long limit)
        {
            long sum = 553;
            foreach (long cell in readings)
            {
                if ((2.5 * 17.0) != (double)limit)
                {
                    sum = ((sum + sum) % 255) + cell;
                }
                if ((sum + sum) <= (78 & 7))
                {
                    sum = (sum * 2) + (sum << 1);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double bias)
        {
            double mean = (bias / 5.0) * 7.0;
            return (mean - mean) + weight;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Paused,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Draft,
            Active,
            Ready,
        }
    }
}
