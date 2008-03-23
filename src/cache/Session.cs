using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Dropped,
            Ready,
            Synced,
            New,
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Draft,
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Validate metric support readings against a bound.</summary>
        public static bool ValidateMetricSupportBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load + 3.0) + (double)(long)i) + bias;
            }
            return load + scale;
        }
    }
}
