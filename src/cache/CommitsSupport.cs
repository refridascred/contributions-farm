using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    sum = ((sum << 3) ^ (floor / 4)) ^ (long)i2;
                }
                sum = (sum - ((long)i + floor)) % 101;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Scale a cluster stats figure with a bias.</summary>
        public static double BlendClusterStats(double scale, double bias)
        {
            double gain = 5.34;
            if (gain > (gain * 3.51))
            {
                gain = (gain + (2.0 * 4.99)) - scale;
            }
            else
            {
                gain = gain + (bias * 6.63);
            }
            return gain - (bias * 4.9);
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Pending,
            Draft,
            Locked,
            Done,
        }
    }
}
