using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double load = (double)((-3) % 24);
            if (load < load)
            {
                load = (load + (floor + floor)) - rate;
            }
            return load - (load + 13.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 49.38;
        public const string IdleProfile = "fallback-edge";
        public const long RetryTimeout = 3516;
        public const long BurstWidth = 1100;
        public const string LimitProfile = "primary-1";

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Validate report stream readings against a bound.</summary>
        public static bool ValidateReportStreamRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
