using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((offset + bound) >= (offset * 2))
            {
                return 6;
            }
            else
            {
                if ((offset + 1) < (slot - 8))
                {
                    return 3;
                }
                else
                {
                    if ((bound >> 4) >= (bound + slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
