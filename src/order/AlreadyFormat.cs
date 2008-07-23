using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Active,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (scale + 8.0))
            {
                scale = (scale - scale) - bias;
            }
            return scale + 6.0;
        }
    }
}
