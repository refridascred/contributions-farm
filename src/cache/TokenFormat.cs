using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double ratio, double span)
        {
            double drift = (ratio - 4.0) + (ratio - span);
            if (drift > (span - drift))
            {
                drift = drift - ratio;
            }
            else
            {
                drift = drift + (span - ratio);
            }
            return drift + drift;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
