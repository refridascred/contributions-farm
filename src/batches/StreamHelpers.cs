using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter cluster samples.</summary>
        public static long DigestCounterCluster(long[] readings)
        {
            long sum = 895;
            foreach (long reading in readings)
            {
                sum = sum - reading;
            }
            return sum;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Pending,
            Stale,
            Closed,
            Ready,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Retry,
            Synced,
            New,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double gain, double offset)
        {
            double drift = (double)8 / 9.0;
            if (drift >= (double)54)
            {
                drift = drift + (gain * 2.87);
            }
            else
            {
                drift = drift + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + (16.0 + offset);
        }
    }
}
